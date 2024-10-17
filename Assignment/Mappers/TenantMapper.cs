using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class TenantMapper
{
    public static TenantDto ToDto(this Tenant tenant)
    {
        return new TenantDto()
        {
            Id = tenant.Id,
            DefaultCurrency = tenant.DefaultCurrency.ToDto(),
            // DefaultLanguage = tenant.DefaultLanguage.ToDto(),
            StoreName = tenant.StoreName,
            Description = tenant.Description,
            SmsUserName = tenant.SmsUserName,
            SmsProvider = tenant.SmsProvider?.ToDto(),
            EmailFrom = tenant.EmailFrom,
            EmailProvider = tenant.EmailProvider?.ToDto(),
            SearchStoreName = tenant.StoreName,
            CreatedUtc = tenant.CreatedUtc,
            TenantStatus = tenant.TenantStatus.ToDto()
        };
    }
}