using Assignment.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment.Dto;

public class SubStoreDto
{
    public long Id { get; set; }
    public CountryDto Country { get; set; } = null!;
    public CityDto City { get; set; } = null!;
    public SubStoreTypeDto? SubStoreType { get; set; }
    public SubStoreStatusDto SubStoreStatus { get; set; } = null!;
    public string? CloseNote { get; set; }
    public string NickName { get; set; } = string.Empty;
    public string SearchNickName { get; set; } = string.Empty;
    public string? DescriptionInEnglish { get; set; } = string.Empty;
    public string? Search { get; set; }
    public string? Email { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public float Rating { get; set; }
    public AvailabilityTypeDto AvailabilityType { get; set; } = null!;
    public SubStoreDto? BranchOf { get; set; }
    public ViewThemeDto ViewTheme { get; set; } = null!;
    public string? Iban { get; set; }
    public MainDomainDto Domain { get; set; } = null!;
    public string? DescriptionInArabic { get; set; }
    public string NameInArabic { get; set; } = " ";
    public string searchNameInArabic { get; set; } = " ";
    public string NameInEnglish { get; set; } = " ";
    public string searchNameInEnglish { get; set; } = " ";
    public string? AreaInArabic { get; set; }
    public string? AreaInEnglish { get; set; }
    public string? CommercialRegistryInArabic { get; set; }
    public string? CommercialRegistryInEnglish { get; set; }
    public string? BankAccountNameInArabic { get; set; }
    public string? BankAccountNameInEnglish { get; set; }
    public List<SubStoreOfferDto> SubStoreOffers { get; set; } = [];
    public List<SubStoreReviewDto> SubStoreReviews { get; set; } = [];
}