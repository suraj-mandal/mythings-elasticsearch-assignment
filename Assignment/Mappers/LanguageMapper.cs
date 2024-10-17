using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class LanguageMapper
{
    public static LanguageDto ToDto(this Language language)
    {
        return new LanguageDto()
        {
            Id = language.Id,
            CreatedUtc = language.CreatedUtc,
            Key = language.Key,
            EnumDescription = language.EnumDescription,
            Flag = language.Flag,
            IsDefault = language.IsDefault,
            Name = language.Name,
        };
    }

    public static LanguageDto ToDtoForCountry(this Language language)
    {
        return new LanguageDto()
        {
            Key = language.Key,
            Name = language.Name,
            EnumDescription = language.EnumDescription,
            Flag = language.Flag,
        };
    }
}