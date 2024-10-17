using Assignment.Constants;
using Assignment.Dto;
using Assignment.Interfaces;
using Nest;

namespace Assignment.Services;

public class ElasticSearchService(IElasticClient elasticClient) : IElasticSearchService
{
    public async Task<IEnumerable<SubStoreDto>> SearchSubStoresAsync(string search, int page = 1, int pageSize = 10)
    {
        await UpdateSearchLogDocumentAsync(search);
        var response = await elasticClient.SearchAsync<SubStoreDto>(s => s
            .Query(q => q
                .MultiMatch(m => m
                    .Fields(f =>
                        f.Field(p => p.NickName)
                            .Field(p => p.NameInEnglish)
                            .Field(p => p.NameInArabic)
                            .Field(p => p.SubStoreType!.Tenant.StoreName)
                    )
                    .Query(search)
                    .Analyzer("standard")
                    .Boost(1.1)
                    .Slop(2)
                    .Fuzziness(Fuzziness.Auto)
                    .Operator(Operator.Or)
                    .MinimumShouldMatch(2)
                ))
            .From((page - 1) * pageSize)
            .Size(pageSize)
            .Sort(ss => ss.Descending(SortSpecialField.Score)));
        var data = response.Hits.Select(c => c.Source);
        return data;
    }

    public async Task<IEnumerable<string>> SearchSuggestionKeywordsAsync(string search, int page = 1, int pageSize = 10)
    {
        await UpdateSearchLogDocumentAsync(search);
        var fetchSize = pageSize * page;

        var response = await elasticClient.SearchAsync<SubStoreDto>(s => s
            .Suggest(su => su
                .Completion("search-suggestions", c => c
                    .Field(f => f.Search)
                    .Prefix(search)
                    .Size(fetchSize)
                )
                .Completion("english-name-suggestions", c => c
                    .Field(f => f.searchNameInEnglish)
                    .Prefix(search)
                    .Size(fetchSize)
                )
                .Completion("arabic-name-suggestions", c => c
                    .Field(f => f.searchNameInArabic)
                    .Prefix(search)
                    .Size(fetchSize)
                )
                .Completion("nick-name-suggestions", c => c
                    .Field(f => f.SearchNickName)
                    .Prefix(search)
                    .Size(fetchSize)
                )
            ));
        var keywords =
            response.Suggest["search-suggestions"]
                .SelectMany(s => s.Options.Select(o => new { o.Text, o.Score }))
                .Concat(response.Suggest["english-name-suggestions"]
                    .SelectMany(s => s.Options.Select(o => new { o.Text, o.Score })))
                .Concat(response.Suggest["arabic-name-suggestions"]
                    .SelectMany(s => s.Options.Select(o => new { o.Text, o.Score })))
                .Concat(response.Suggest["nick-name-suggestions"]
                    .SelectMany(s => s.Options.Select(o => new { o.Text, o.Score })))
                .DistinctBy(s => s.Text)
                .OrderByDescending(s => s.Score)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(s => s.Text)
                .ToList();
        return keywords;
    }

    public async Task<IEnumerable<string>> GetMostSearchedWordsAsync(int pageSize = 10)
    {
        var response = await elasticClient.SearchAsync<SearchLogDto>(s =>
            s.Index("search-logs")
                .Size(0)
                .Aggregations(a => a
                    .Terms("most_common_keywords", t => t
                        .Field(f => f.SearchQuery)
                        .Size(pageSize)))
        );

        var topWords = response.Aggregations.Terms("most_common_keywords")
            .Buckets
            .Select(b => b.Key)
            .ToList();
        return topWords;
    }

    private async Task UpdateSearchLogDocumentAsync(string search)
    {
        var searchLog = new SearchLogDto()
        {
            SearchQuery = search,
        };

        await elasticClient.IndexAsync(searchLog, i =>
            i.Index(IndexNameConstants.SearchLogIndexName));
    }
}