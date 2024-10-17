namespace Assignment.Dto;

public class SubStoreOfferDto
{
    public long Id { get; set; }
    public string? TitleArabic { get; set; }
    public string? TitleEnglish { get; set; }
    public float Amount { get; set; }
    public DateTime StartUtc { get; set; }
    public DateTime? EndUtc { get; set; }
    public DateTime CreatedUtc { get; set; }
    public string? SecondTitleArabic { get; set; }
    public string? SecondTitleEnglish { get; set; }
}