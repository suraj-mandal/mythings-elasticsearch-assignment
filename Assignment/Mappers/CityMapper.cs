using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class CityMapper
{
    public static CityDto ToDto(this City city)
    {
        return new CityDto()
        {
            Id = city.Id,
            Key = city.Key,
            EnumDescription = city.EnumDescription,
            Country = city.Country.ToDto(),
            Latitude = city.Latitude,
            Longitude = city.Longitude,
        };
    }
}