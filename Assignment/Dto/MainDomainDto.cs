namespace Assignment.Dto;

public class MainDomainDto
{
    public long Id { get; set; }
    public string TitleArabic { get; set; } = string.Empty;
    public string TitleEnglish { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public GeneralStatusDto? DomainStatus { get; set; } = null!;
    public DateTime CreatedUtc { get; set; }
    public bool IsRestaurant { get; set; }
}