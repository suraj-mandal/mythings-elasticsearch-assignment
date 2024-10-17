namespace Assignment.Dto;

public class SubStoreTypeDto
{
    public int Id { get; set; }
    public TenantDto Tenant { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsDefault { get; set; }
}