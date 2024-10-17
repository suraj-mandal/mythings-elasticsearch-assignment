using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("AvailabilityType")]
public class AvailabilityType
{
    public int Id { get; set; }
    [MaxLength(100)] public string Key { get; set; } = string.Empty;
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
}