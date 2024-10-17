using Assignment.Models;

namespace Assignment.Dto;

public class TenantDto
{
    public Guid Id { get; set; }
    public CurrencyTypeDto DefaultCurrency { get; set; } = null!;
    public TenantStatusDto TenantStatus { get; set; } = null!;
    public string StoreName { get; set; } = string.Empty;
    public string SearchStoreName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? SmsUserName { get; set; }
    public SmsProviderTypeDto? SmsProvider { get; set; }
    public string? EmailFrom { get; set; }
    public EmailProviderTypeDto? EmailProvider { get; set; }
    public DateTime CreatedUtc { get; set; }
}