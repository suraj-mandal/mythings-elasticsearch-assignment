using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class AvailabilityTypeMapper
{
    public static AvailabilityTypeDto ToDto(this AvailabilityType availabilityType)
    {
        return new AvailabilityTypeDto()
        {
            Id = availabilityType.Id,
            Key = availabilityType.Key,
        };
    }
}