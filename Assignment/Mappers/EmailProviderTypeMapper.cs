using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class EmailProviderTypeMapper
{
    public static EmailProviderTypeDto ToDto(this EmailProviderType emailProviderType)
    {
        return new EmailProviderTypeDto()
        {
            Id = emailProviderType.Id,
            Key = emailProviderType.Key,
            EnumDescription = emailProviderType.EnumDescription,
        };
    }
}