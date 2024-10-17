using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("SubStore")]
public class SubStore
{
    public long Id { get; set; }
    public int CountryId { get; set; } // will need to create country model for this
    public Country Country { get; set; } = null!;
    public int CityId { get; set; } // will need to create city model for this
    public City City { get; set; } = null!;
    public int? SubStoreTypeId { get; set; } // will need to create SubStoreType model for this
    public SubStoreType? SubStoreType { get; set; }
    public float Random { get; set; }
    public DateTime RandomDate { get; set; }
    public long SubStoreStatusId { get; set; } // will need to create SubStoreStatus model for this
    public SubStoreStatus SubStoreStatus { get; set; } = null!;
    [Column("RecieveOrderWhileClosed")] public bool ReceiveOrderWhileClosed { get; set; }

    public string? CloseNote { get; set; }

    [MaxLength(100)] public string NickName { get; set; } = string.Empty;

    [MaxLength(500)]
    [Column("Description_en")]
    public string? DescriptionInEnglish { get; set; } = string.Empty;

    [MaxLength(100)] public string Phone { get; set; } = string.Empty;

    public string? Search { get; set; }

    [MaxLength(100)] public string? Email { get; set; }

    public bool IsOrdered { get; set; }

    [Column("latitude")] public float Latitude { get; set; }

    [Column("longitude")] public float Longitude { get; set; }

    public float Rating { get; set; }

    public int RatingCount { get; set; } = 0;

    public float? Commission { get; set; }

    public DateTime CreatedUtc { get; set; } = DateTime.Now;

    [Column("AvailabilityId")] public int AvailabilityTypeId { get; set; } = 1; // will refer AvailabilityType
    public AvailabilityType AvailabilityType { get; set; } = null!;
    public int Busy { get; set; }
    public long? BranchOfId { get; set; } // refers to SubStore
    public SubStore? BranchOf { get; set; }

    public long ViewThemeId { get; set; } = 1L; // will refer to ViewTheme
    public ViewTheme ViewTheme { get; set; } = null!;
    public bool ApplyTax { get; set; }
    public int TaxRatio { get; set; } = 16;
    public float ServiceFee { get; set; } = 0;
    public bool TaxExemption { get; set; } = false;

    [Column("IBAN")] [MaxLength(30)] public string? Iban { get; set; }

    public bool IsCashOnSpot { get; set; } = false;
    public long DomainId { get; set; } = 6; // refers to MainDomain
    public MainDomain Domain { get; set; } = null!;


    [Column("Description_ar")]
    [MaxLength(500)]
    public string? DescriptionInArabic { get; set; }

    [Column("Name_ar")] [MaxLength(100)] public string NameInArabic { get; set; } = " ";

    [Column("Name_en")] [MaxLength(100)] public string NameInEnglish { get; set; } = " ";

    [Column("IsStuffToExperiance")] public bool IsStuffToExperience { get; set; } = false;

    public bool IsTopPickedForYou { get; set; } = false;
    public float MinOrder { get; set; } = 0;
    public string? Area { get; set; }

    [Column("AreaName_ar")] public string? AreaInArabic { get; set; }

    [Column("AreaName_en")] public string? AreaInEnglish { get; set; }

    [Column("CommercialRegistry_ar")] public string? CommercialRegistryInArabic { get; set; }
    [Column("CommercialRegistry_en")] public string? CommercialRegistryInEnglish { get; set; }
    [Column("BankAccountName_ar")] public string? BankAccountNameInArabic { get; set; }
    [Column("BankAccountName_en")] public string? BankAccountNameInEnglish { get; set; }
    public DateTime? BusyUntil { get; set; }

    public List<SubStoreOffer> SubStoreOffers { get; set; } = [];
    public List<SubStoreReview> SubStoreReviews { get; set; } = [];
}