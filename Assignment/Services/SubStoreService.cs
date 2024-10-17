using Assignment.Dto;
using Assignment.Interfaces;
using Assignment.Mappers;

namespace Assignment.Services;

public class SubStoreService(ISubStoreRepository subStoreRepository) : ISubStoreService
{
    public async Task<List<SubStoreDto>> GetAllSubStores(int page, int pageSize)
    {
        var subStores = await subStoreRepository.GetAllSubStoresAsync(page, pageSize);
        return subStores.Select(s => s.ToDto()).ToList();
    }
    
    public async Task<List<SubStoreDto>> GetAllSubStores()
    {
        var subStores = await subStoreRepository.GetAllSubStoresAsync();
        return subStores.Select(s => s.ToDto()).ToList();
    }
}