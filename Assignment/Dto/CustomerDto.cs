namespace Assignment.Dto;

public class CustomerDto
{
    public long Id { get; set; }
    public string LoginAccount { get; set; } = string.Empty;
    public string Search { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string? LastName { get; set; }
    public string? Topic { get; set; }
}