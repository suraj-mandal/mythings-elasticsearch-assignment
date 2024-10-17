using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class SubStoreTypeMapper
{
    public static SubStoreTypeDto ToDto(this SubStoreType subStoreType)
    {
        return new SubStoreTypeDto()
        {
            Id = subStoreType.Id,
            Tenant = subStoreType.Tenant.ToDto(),
            Name = subStoreType.Name,
            Description = subStoreType.Description,
            IsDefault = subStoreType.IsDefault
        };
    }
}