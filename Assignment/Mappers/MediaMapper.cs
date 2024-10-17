using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class MediaMapper
{
    public static MediaDto ToDto(this Media media)
    {
        return new MediaDto()
        {
            Id = media.Id,
            Tenant = media.Tenant?.ToDto(),
            Name = media.Name,
            Alt = media.Alt,
            Search = media.Search,
            CreatedUtc = media.CreatedUtc,
        };
    }
}