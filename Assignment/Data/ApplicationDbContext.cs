using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    
    public DbSet<SubStore> SubStores { get; set; }
    public DbSet<SubStoreOffer> SubStoreOffers { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<SubStoreReview> SubStoreReviews { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<AvailabilityType> AvailabilityTypes { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<CurrencyType> CurrencyTypes { get; set; }
    public DbSet<EmailProviderType> EmailProviderTypes { get; set; }
    public DbSet<SmsProviderType> SmsProviderTypes { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantStatus> TenantStatuses { get; set; }
    public DbSet<GeneralStatus> GeneralStatuses { get; set; }
    public DbSet<MainDomain> MainDomains { get; set; }
    public DbSet<ViewTheme> ViewThemes { get; set; }
    public DbSet<SubStoreStatus> SubStoreStatuses { get; set; }
    public DbSet<SubStoreType> SubStoreTypes { get; set; }
    public DbSet<Media> Medias { get; set; }
}