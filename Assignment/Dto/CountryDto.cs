namespace Assignment.Dto;

public class CountryDto
{
    public int Id { get; set; }
    public DateTime CreatedUtc { get; set; }
    public string Key { get; set; } = string.Empty;
    public string? EnumDescription { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public string IsoAlpha2 { get; set; } = string.Empty;
    public string IsoAlpha3 { get; set; } = string.Empty;
    public string PhoneCode { get; set; } = string.Empty;
    public LanguageDto? DefaultLanguage { get; set; }
    public long? DefaultCurrencyTypeId { get; set; }
}