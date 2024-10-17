using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class GeneralStatusMapper
{
    public static GeneralStatusDto? ToDto(this GeneralStatus generalStatus)
    {
        return new GeneralStatusDto()
        {
            Id = generalStatus.Id,
            Code = generalStatus.Code,
            NameArabic = generalStatus.NameArabic,
            NameEnglish = generalStatus.NameEnglish,
            CreatedAt = generalStatus.CreatedAt,
            UpdatedAt = generalStatus.UpdatedAt,
            DeletedAt = generalStatus.DeletedAt
        };
    }
}