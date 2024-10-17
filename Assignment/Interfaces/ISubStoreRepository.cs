using Assignment.Models;

namespace Assignment.Interfaces;

public interface ISubStoreRepository
{
    Task<List<SubStore>> GetAllSubStoresAsync();
    Task<List<SubStore>> GetAllSubStoresAsync(int page, int pageSize);
}