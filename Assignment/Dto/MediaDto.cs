namespace Assignment.Dto;

public class MediaDto
{
    public long Id { get; set; }
    public TenantDto? Tenant { get; set; }
    public string? Name { get; set; }
    public string? Alt { get; set; }
    public string? Search { get; set; }
    public DateTime CreatedUtc { get; set; }
}