using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("Media")]
public class Media
{
    public long Id { get; set; }
    public Guid? TenantId { get; set; }
    public Tenant? Tenant { get; set; }
    [MaxLength(500)] public string? Name { get; set; }
    [MaxLength(500)] public string? Alt { get; set; }
    [MaxLength(500)] public string? Search { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public int AvailabilityId { get; set; } = 1;
    public AvailabilityType Availability { get; set; } = null!;
}