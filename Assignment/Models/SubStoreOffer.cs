using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("SubstoreOffer")]
public class SubStoreOffer
{
    public long Id { get; set; }
    [Column("Title_ar")] [MaxLength(100)] public string? TitleArabic { get; set; }
    [Column("Title_en")] [MaxLength(100)] public string? TitleEnglish { get; set; }
    [Column("SubstoreId")] public long SubStoreId { get; set; }
    public SubStore SubStore { get; set; } = null!;
    public int StatusId { get; set; }
    public GeneralStatus Status { get; set; } = null!;
    public float Amount { get; set; }
    public DateTime StartUtc { get; set; }
    public DateTime? EndUtc { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public int AvailabilityId { get; set; } = 1;
    public AvailabilityType Availability { get; set; } = null!;

    [Column("Title_2_ar")]
    [MaxLength(100)]
    public string? SecondTitleArabic { get; set; }

    [Column("Title_2_en")]
    [MaxLength(100)]
    public string? SecondTitleEnglish { get; set; }
}