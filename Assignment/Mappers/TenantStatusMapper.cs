using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class TenantStatusMapper
{
    public static TenantStatusDto ToDto(this TenantStatus tenantStatus)
    {
        return new TenantStatusDto()
        {
            Id = tenantStatus.Id,
            Key = tenantStatus.Key,
            EnumDescription = tenantStatus.EnumDescription,
        };
    }
}