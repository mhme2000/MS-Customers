namespace Customers.Domain.Entities;

public class Customer(string document, string email, string name) : Entity
{
    public string Email { get; private set; } = email;
    public string Document { get; private set; } = document;
    public string Name { get; private set; } = name;
}