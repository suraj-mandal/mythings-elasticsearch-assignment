using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class ViewThemeMapper
{
    public static ViewThemeDto ToDto(this ViewTheme viewTheme)
    {
        return new ViewThemeDto()
        {
            Id = viewTheme.Id,
            ParentViewTheme = viewTheme.ParentViewTheme?.ToDto(),
            Key = viewTheme.Key,
            EnumDescription = viewTheme.EnumDescription,
            CreatedUtc = viewTheme.CreatedUtc,
        };
    }
}