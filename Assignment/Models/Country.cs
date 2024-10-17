using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("Country")]
public class Country
{
    public int Id { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;

    [Column("AvailabilityId")] public int AvailabilityTypeId { get; set; } = 1; // references AvailabilityType
    public AvailabilityType AvailabilityType { get; set; } = null!;
    [MaxLength(100)] public string Key { get; set; } = string.Empty;

    [MaxLength(500)] public string? EnumDescription { get; set; }

    public float Latitude { get; set; }
    public float Longitude { get; set; }

    [Column("ISOAlpha_2")] [MaxLength(25)] public string IsoAlpha2 { get; set; } = string.Empty;

    [Column("ISOAlpha_3")] [MaxLength(25)] public string IsoAlpha3 { get; set; } = string.Empty;
    public bool DisableAppSignup { get; set; }
    [MaxLength(25)] public string PhoneCode { get; set; } = string.Empty;

    public long? DefaultCurrencyTypeId { get; set; }
    public int? DefaultLanguageId { get; set; } // references the language table
    public Language? DefaultLanguage { get; set; }
    public string TimeZone { get; set; } = string.Empty;
}