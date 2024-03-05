namespace Customers.Domain.Entities;

public class Customer(string document, string email, string name, string? address, string? phone) : Entity
{
    public string Email { get; set; } = email;
    public string Document { get; set; } = document;
    public string Name { get; set; } = name;
    public string? Address { get; set; } = address;
    public string? Phone { get; set; } = phone;
}