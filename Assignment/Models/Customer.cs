using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models;

[Table("Customer")]
public class Customer
{
    public long Id { get; set; }
    [MaxLength(100)] public string LoginAccount { get; set; } = string.Empty;
    public string Search { get; set; } = string.Empty;
    [MaxLength(500)] public string? Email { get; set; }
    [MaxLength(500)] public string? Phone { get; set; }
    [MaxLength(100)] public string FirstName { get; set; } = string.Empty;
    [MaxLength(100)] public string? LastName { get; set; }
    public string? Topic { get; set; }
}