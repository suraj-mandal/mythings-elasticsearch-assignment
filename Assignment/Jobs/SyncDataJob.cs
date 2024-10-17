using Assignment.Constants;
using Assignment.Data;
using Assignment.Dto;
using Assignment.Mappers;
using Microsoft.EntityFrameworkCore;
using Nest;
using Quartz;

namespace Assignment.Jobs;

[DisallowConcurrentExecution]
public class SyncDataJob(
    IElasticClient elasticClient,
    ILogger<SyncDataJob> logger,
    ApplicationDbContext applicationDbContext)
    : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        logger.LogInformation("Starting sync data job...");

        
        await CreateSubStoreIndexIfNotExistsAsync();

        await CreateSearchLogIndexIfNotExistsAsync();


        var data = await applicationDbContext.SubStores
            .Include(s => s.Country).ThenInclude(c => c.DefaultLanguage)
            .Include(s => s.AvailabilityType)
            .Include(s => s.SubStoreType).ThenInclude(s => s!.Tenant).ThenInclude(t => t.DefaultCurrency)
            .Include(s => s.SubStoreType).ThenInclude(s => s!.Tenant).ThenInclude(t => t.TenantStatus)
            .Include(s => s.SubStoreType).ThenInclude(s => s!.Tenant).ThenInclude(t => t.SmsProvider)
            .Include(s => s.SubStoreType).ThenInclude(s => s!.Tenant).ThenInclude(t => t.EmailProvider)
            .Include(s => s.City)
            .Include(s => s.SubStoreStatus)
            .Include(s => s.BranchOf)
            .Include(s => s.Domain)
            .Include(s => s.ViewTheme)
            .Include(s => s.SubStoreOffers)
            .Include(s => s.SubStoreReviews).ThenInclude(s => s.Customer)
            .Select(s => s.ToDto())
            .ToListAsync();


        var bulkDescriptor = new BulkDescriptor();

        foreach (var store in data)
        {
            bulkDescriptor.Index<SubStoreDto>(op => op.Document(store).Index(IndexNameConstants.SubStoreIndexName));
        }

        var response = await elasticClient.BulkAsync(bulkDescriptor);

        if (response.Errors)
        {
            logger.LogError("Errors occurred during Elasticsearch bulk indexing: {Errors}",
                response.ServerError);
        }
        else
        {
            logger.LogInformation("Data Sync completed successfully.");
        }
    }

    private async Task CreateSubStoreIndexIfNotExistsAsync()
    {
        var indexName = IndexNameConstants.SubStoreIndexName;
        logger.LogInformation("Checking if index {index} exists.", indexName);

        var existsResponse = await elasticClient.Indices.ExistsAsync(indexName);

        if (!existsResponse.Exists)
        {
            logger.LogInformation("Index {index} does not exist. Creating the index...", indexName);
            await elasticClient.Indices.CreateAsync(indexName, c => c
                .Map<SubStoreDto>(m => m.Properties(p =>
                        p.Completion(cp => cp.Name(s => s.SearchNickName))
                            .Completion(cp => cp.Name(s => s.searchNameInEnglish))
                            .Completion(cp => cp.Name(s => s.searchNameInArabic))
                            .Completion(cp => cp.Name(s => s.SubStoreType!.Tenant.SearchStoreName))
                            .Completion(cp => cp.Name(s => s.Search))
                    )
                )
            );
            logger.LogInformation("Index {index} created successfully.", indexName);
        }
        else
        {
            logger.LogInformation("Index {index} already exists.", indexName);
        }
    }

    private async Task CreateSearchLogIndexIfNotExistsAsync()
    {
        var indexName = IndexNameConstants.SearchLogIndexName;
        logger.LogInformation("Checking if index {index} exists.", indexName);

        var existsResponse = await elasticClient.Indices.ExistsAsync(indexName);
        if (!existsResponse.Exists)
        {
            logger.LogInformation("Index {index} does not exist. Creating the index...", indexName);
            await elasticClient.Indices.CreateAsync(indexName, c => c
                .Map<SearchLogDto>(m => m
                    .Properties(p => p
                        .Keyword(k => k.Name(n => n.SearchQuery))
                        .Date(d => d.Name(n => n.CreatedAt)))));
            logger.LogInformation("Index {index} created successfully.", indexName);
        }
        else
        {
            logger.LogInformation("Index {index} already exists.", indexName);
        }
    }
}