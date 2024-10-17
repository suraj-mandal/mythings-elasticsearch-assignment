using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("City")]
public class City
{
    public int Id { get; set; }
    public Guid? TenantId { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    [Column("AvailabilityId")] public int AvailabilityTypeId { get; set; } = 1;
    public AvailabilityType AvailabilityType { get; set; } = null!;
    [MaxLength(100)] public string Key { get; set; } = string.Empty;
    [MaxLength(500)] public string? EnumDescription { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; } = null!;
    public float Latitude { get; set; }
    public float Longitude { get; set; }
}