namespace Assignment.Dto;

public class SubStoreStatusDto
{
    public long Id { get; set; }
    public DateTime CreatedUtc { get; set; }
    public string Key { get; set; } = string.Empty;
    public string? EnumDescription { get; set; }
}