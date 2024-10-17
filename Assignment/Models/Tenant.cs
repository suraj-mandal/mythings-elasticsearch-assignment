using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("Tenant")]
public class Tenant
{
    public Guid Id { get; set; }
    public long DefaultCurrencyId { get; set; } // references CurrencyType
    public CurrencyType DefaultCurrency { get; set; } = null!;
    [Column("StatusId")] public long TenantStatusId { get; set; } // references TenantStatus
    public TenantStatus TenantStatus { get; set; } = null!;
    public int DefaultLanguageId { get; set; }
    public Language DefaultLanguage { get; set; } = null!;
    [MaxLength(100)] public string StoreName { get; set; } = string.Empty;
    [MaxLength(500)] public string? Description { get; set; }

    public long StoreTypeId { get; set; }
    [Column("SMSUserName")] public string? SmsUserName { get; set; }
    [Column("SMSProviderId")] public long? SmsProviderId { get; set; } // references SmsProviderType
    public SmsProviderType? SmsProvider { get; set; }
    public string? EmailFrom { get; set; }
    public long? EmailProviderId { get; set; } // references EmailProviderType
    public EmailProviderType? EmailProvider { get; set; }
    [Column("DefaultCountryId")] public int? TenantCountryId { get; set; }
    public Country? TenantCountry { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public int AvailabilityId { get; set; } = 1;
    public AvailabilityType Availability { get; set; } = null!;
}