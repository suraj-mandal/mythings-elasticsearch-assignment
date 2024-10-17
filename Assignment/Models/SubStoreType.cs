using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("SubStoreType")]
public class SubStoreType
{
    public int Id { get; set; }
    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;
    [MaxLength(100)] public string Name { get; set; } = string.Empty;
    [MaxLength(500)] public string? Description { get; set; }
    public bool IsDefault { get; set; }
    public int Validity { get; set; }
    public float Commission { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public int AvailabilityId { get; set; } = 1;
    public AvailabilityType Availability { get; set; } = null!;
}