using Assignment.Data;
using Assignment.Interfaces;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Repositories;

public class SubStoreRepository(ApplicationDbContext context) : ISubStoreRepository
{
    public async Task<List<SubStore>> GetAllSubStoresAsync()
    {
        var subStores = await
            context.SubStores
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
                .ToListAsync();
        return subStores;
    }

    public async Task<List<SubStore>> GetAllSubStoresAsync(int page, int pageSize)
    {
        var skipNumber = (page - 1) * pageSize;
        var subStores = await
            context.SubStores.Skip(skipNumber)
                .Take(pageSize)
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
                .ToListAsync();
        return subStores;
    }
}