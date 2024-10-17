using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("ViewTheme")]
public class ViewTheme
{
    public long Id { get; set; }
    [Column("ViewThemeId")] public long? ParentViewThemeId { get; set; }
    public ViewTheme? ParentViewTheme { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public int AvailabilityId { get; set; } = 1;
    public AvailabilityType Availability { get; set; } = null!;
    [MaxLength(100)] public string Key { get; set; } = string.Empty;
    [MaxLength(500)] public string? EnumDescription { get; set; }
}