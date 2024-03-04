namespace Customers.Domain.Entities;

public class Customer : Entity
{
    public Customer(string document, string email, string name)
    {
        Email = email;
        Document = document;
        Name = name;
    }

    public string Email { get; private set; }
    public string Document { get; private set; }
    public string Name { get; private set; }
}