namespace Assignment.Dto;

public class SearchLogDto
{
    public string SearchQuery { get; set; } = string.Empty;
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}