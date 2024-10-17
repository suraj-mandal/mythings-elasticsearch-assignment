namespace Assignment.Dto;

public class SubStoreReviewDto
{
    public long Id { get; set; }
    public CustomerDto Customer { get; set; } = null!;
    public string? Comment { get; set; }
    public float Rating { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public bool IsPublished { get; set; } = true;
}