using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class SmsProviderTypeMapper
{
    public static SmsProviderTypeDto ToDto(this SmsProviderType smsProviderType)
    {
        return new SmsProviderTypeDto()
        {
            Id = smsProviderType.Id,
            Key = smsProviderType.Key,
            EnumDescription = smsProviderType.EnumDescription,
        };
    }
}