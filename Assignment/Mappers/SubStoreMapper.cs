using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class SubStoreMapper
{
    public static SubStoreDto ToDto(this SubStore subStore)
    {
        return new SubStoreDto()
        {
            Id = subStore.Id,
            Country = subStore.Country.ToDto(),
            SubStoreType = subStore.SubStoreType?.ToDto(), 
            SubStoreStatus = subStore.SubStoreStatus.ToDto(),
            City = subStore.City.ToDto(),
            CloseNote = subStore.CloseNote,
            NickName = subStore.NickName,
            DescriptionInEnglish = subStore.DescriptionInEnglish,
            Search = subStore.Search,
            Email = subStore.Email,
            Latitude = subStore.Latitude,
            Longitude = subStore.Longitude,
            Rating = subStore.Rating,
            AvailabilityType = subStore.AvailabilityType.ToDto(),
            ViewTheme = subStore.ViewTheme.ToDto(),
            Iban = subStore.Iban,
            Domain = subStore.Domain.ToDto(), 
            DescriptionInArabic = subStore.DescriptionInArabic,
            NameInArabic = subStore.NameInArabic,
            NameInEnglish = subStore.NameInEnglish,
            AreaInEnglish = subStore.AreaInEnglish,
            AreaInArabic = subStore.AreaInArabic,
            CommercialRegistryInArabic = subStore.CommercialRegistryInArabic,
            CommercialRegistryInEnglish = subStore.CommercialRegistryInEnglish,
            BankAccountNameInArabic = subStore.BankAccountNameInArabic,
            BankAccountNameInEnglish = subStore.BankAccountNameInEnglish,
            SearchNickName = subStore.NickName,
            searchNameInArabic = subStore.NameInArabic,
            searchNameInEnglish = subStore.NameInEnglish,
            SubStoreOffers = subStore.SubStoreOffers.Select(s => s.ToDto()).ToList(),
            SubStoreReviews = subStore.SubStoreReviews.Select(s => s.ToDto()).ToList(),
        };
    }
}