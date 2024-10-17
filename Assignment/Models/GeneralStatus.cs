using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("GeneralStatus")]
public class GeneralStatus
{
    public int Id { get; set; }
    [MaxLength(50)] public string Code { get; set; } = string.Empty;
    [Column("Name_ar")] [MaxLength(500)] public string NameArabic { get; set; } = string.Empty;
    [Column("Name_en")] [MaxLength(500)] public string NameEnglish { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}