namespace Assignment.Dto;

public class CurrencyTypeDto
{
    public long Id { get; set; }
    public string Key { get; set; } = string.Empty;
    public string? EnumDescription { get; set; }
    public string Code { get; set; } = string.Empty;
    public int DecimalDigits { get; set; }
    public int Rounding { get; set; }
}