using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class AreaMapper
{
    public static AreaDto ToDto(this Area area)
    {
        return new AreaDto()
        {
            Id = area.Id,
            Key = area.Key,
            EnumDescription = area.EnumDescription,
            City = area.City?.ToDto(),
            Tenant = area.Tenant?.ToDto()
        };
    }
}