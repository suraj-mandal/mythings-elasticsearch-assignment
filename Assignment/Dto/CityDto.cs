using Assignment.Models;

namespace Assignment.Dto;

public class CityDto
{
    public int Id { get; set; }
    public string Key { get; set; } = string.Empty;
    public string? EnumDescription { get; set; }
    public CountryDto Country { get; set; } = null!;
    public float Latitude { get; set; }
    public float Longitude { get; set; }
}