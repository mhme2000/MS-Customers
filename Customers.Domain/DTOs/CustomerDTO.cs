using System.ComponentModel.DataAnnotations;

namespace Customers.Domain.DTOs;

public class CustomerDTO
{
    [Required]
    public string Email { get; set; } = null!;
    [Required]
    public string Document { get; set; } = null!;
    [Required]
    public string Name { get; set; } = null!;
    public string? Phone { get; set; }
    public string? Address { get; set; }
}