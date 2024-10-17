using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class SubStoreStatusMapper
{
    public static SubStoreStatusDto ToDto(this SubStoreStatus subStoreStatus)
    {
        return new SubStoreStatusDto()
        {
            Id = subStoreStatus.Id,
            CreatedUtc = subStoreStatus.CreatedUtc,
            Key = subStoreStatus.Key,
            EnumDescription = subStoreStatus.EnumDescription,
        };
    }
}