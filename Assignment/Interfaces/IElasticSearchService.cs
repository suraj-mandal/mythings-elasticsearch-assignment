using Assignment.Dto;
using Assignment.Helpers;

namespace Assignment.Interfaces;

public interface IElasticSearchService
{
    Task<IEnumerable<SubStoreDto>> SearchSubStoresAsync(string search, int page = 1, int pageSize = 10);
    Task<IEnumerable<string>> SearchSuggestionKeywordsAsync(string search, int page = 1, int pageSize = 10);
    Task<IEnumerable<string>> GetMostSearchedWordsAsync(int pageSize = 10);
}