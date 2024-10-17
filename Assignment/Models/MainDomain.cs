using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("MainDomain")]
public class MainDomain
{
    public long Id { get; set; }
    [Column("Title_ar")] public string TitleArabic { get; set; } = string.Empty;
    [Column("Title_en")] public string TitleEnglish { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public int DomainStatusId { get; set; }
    public GeneralStatus DomainStatus { get; set; } = null!;
    public long MediaId { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public int AvailabilityId { get; set; } = 1;
    public AvailabilityType Availability { get; set; } = null!;
    [Column("isResturant")] public bool IsRestaurant { get; set; } = false;
}