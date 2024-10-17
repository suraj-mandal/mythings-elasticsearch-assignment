using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class CurrencyTypeMapper
{
    public static CurrencyTypeDto ToDto(this CurrencyType currencyType)
    {
        return new CurrencyTypeDto()
        {
            Id = currencyType.Id,
            Key = currencyType.Key,
            EnumDescription = currencyType.EnumDescription,
            Code = currencyType.Code,
            DecimalDigits = currencyType.DecimalDigits,
            Rounding = currencyType.Rounding,
        };
    }
}