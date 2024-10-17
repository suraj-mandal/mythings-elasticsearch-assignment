using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("Language")]
public class Language
{
    public int Id { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    [Column("AvailabilityId")] public int AvailabilityTypeId { get; set; } = 1;
    public AvailabilityType AvailabilityType { get; set; } = null!;
    public string Key { get; set; } = string.Empty;
    public string? EnumDescription { get; set; }
    public string Flag { get; set; } = string.Empty;
    public bool IsDefault { get; set; }

    [Column("isRTL")] public bool IsRtl { get; set; }
    [Column("ISO639_1Code")] public string Iso639_1Code { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;
    [Column("Is_AdminWeb_Interfce")] public bool IsAdminWebInterface { get; set; }

    [Column("Is_AdminMobileApp_Interfce")] public bool IsAdminMobileAppInterface { get; set; }

    public bool IsEnabled { get; set; }
}