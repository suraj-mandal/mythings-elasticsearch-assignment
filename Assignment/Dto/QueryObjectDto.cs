namespace Assignment.Helpers;

public class QueryObjectDto
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 20;
    public string Query { get; set; } = string.Empty;
}