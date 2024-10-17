using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class SubStoreOfferMapper
{
    public static SubStoreOfferDto ToDto(this SubStoreOffer subStoreOffer)
    {
        return new SubStoreOfferDto()
        {
            Id = subStoreOffer.Id,
            Amount = subStoreOffer.Amount,
            TitleArabic = subStoreOffer.TitleArabic,
            TitleEnglish = subStoreOffer.TitleEnglish,
            StartUtc = subStoreOffer.StartUtc,
            EndUtc = subStoreOffer.EndUtc,
            CreatedUtc = subStoreOffer.CreatedUtc,
            SecondTitleArabic = subStoreOffer.SecondTitleArabic,
            SecondTitleEnglish = subStoreOffer.SecondTitleEnglish,
        };
    }
}