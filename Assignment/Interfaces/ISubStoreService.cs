using Assignment.Dto;

namespace Assignment.Interfaces;

public interface ISubStoreService
{
    public Task<List<SubStoreDto>> GetAllSubStores(int page, int pageSize);
    public Task<List<SubStoreDto>> GetAllSubStores();
}