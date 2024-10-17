using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class MainDomainMapper
{
    public static MainDomainDto ToDto(this MainDomain mainDomain)
    {
        return new MainDomainDto()
        {
            Id = mainDomain.Id,
            TitleArabic = mainDomain.TitleArabic,
            TitleEnglish = mainDomain.TitleEnglish,
            DomainStatus = mainDomain.DomainStatus?.ToDto(),
            CreatedUtc = mainDomain.CreatedUtc,
            IsRestaurant = mainDomain.IsRestaurant
        };
    }
}