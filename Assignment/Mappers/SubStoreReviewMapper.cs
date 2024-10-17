using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class SubStoreReviewMapper
{
    public static SubStoreReviewDto ToDto(this SubStoreReview subStoreReview)
    {
        return new SubStoreReviewDto()
        {
            Id = subStoreReview.Id,
            Customer = subStoreReview.Customer.ToDto(),
            CreatedUtc = subStoreReview.CreatedUtc,
            Comment = subStoreReview.Comment,
            Rating = subStoreReview.Rating,
            IsPublished = subStoreReview.IsPublished,
        };
    }
}