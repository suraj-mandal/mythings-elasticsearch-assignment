using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class CountryMapper
{
    public static CountryDto ToDto(this Country country)
    {
        return new CountryDto()
        {
            Id = country.Id,
            CreatedUtc = country.CreatedUtc,
            Key = country.Key,
            EnumDescription = country.EnumDescription,
            Latitude = country.Latitude,
            Longitude = country.Longitude,
            IsoAlpha2 = country.IsoAlpha2,
            IsoAlpha3 = country.IsoAlpha3,
            PhoneCode = country.PhoneCode,
            DefaultLanguage = country.DefaultLanguage?.ToDtoForCountry(),
            DefaultCurrencyTypeId = country.DefaultCurrencyTypeId,
        };
    }
}