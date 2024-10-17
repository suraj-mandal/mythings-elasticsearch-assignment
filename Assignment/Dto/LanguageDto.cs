namespace Assignment.Dto;

public class LanguageDto
{
    public int Id { get; set; }
    public DateTime CreatedUtc { get; set; }
    public string Key { get; set; } = string.Empty;
    public string? EnumDescription { get; set; }
    public string Flag { get; set; } = string.Empty;
    public bool IsDefault { get; set; }
    public string Name { get; set; } = string.Empty;
}