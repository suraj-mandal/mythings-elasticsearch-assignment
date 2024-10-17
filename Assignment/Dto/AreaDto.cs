using Assignment.Models;

namespace Assignment.Dto;

public class AreaDto
{
    public long Id { get; set; }
    public string Key { get; set; } = string.Empty;
    public string? EnumDescription { get; set; }
    public CityDto? City { get; set; }
    public TenantDto? Tenant { get; set; }
}