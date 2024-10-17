using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("SubStoreReview")]
public class SubStoreReview
{
    public long Id { get; set; }
    public long CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
    [Column("SubstoreId")]
    public long SubStoreId { get; set; }
    public SubStore SubStore { get; set; } = null!;
    public string? Comment { get; set; }
    public float Rating { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public int AvailabilityId { get; set; } = 1;
    public AvailabilityType Availability { get; set; } = null!;
    public bool IsPublished { get; set; } = true;
    
}