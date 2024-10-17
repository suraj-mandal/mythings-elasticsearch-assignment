using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("Area")]
public class Area
{
    public long Id { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public int AvailabilityId { get; set; } = 1;
    public AvailabilityType Availability { get; set; } = null!;
    [MaxLength(100)] public string Key { get; set; } = string.Empty;
    [MaxLength(500)] public string? EnumDescription { get; set; }
    public int CityId { get; set; }
    public City City { get; set; } = null!;
    public Guid? TenantId { get; set; }
    public Tenant? Tenant { get; set; }
}