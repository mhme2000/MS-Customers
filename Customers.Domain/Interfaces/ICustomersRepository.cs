using Customers.Domain.Entities;

namespace Customers.Domain.Interfaces;

public interface ICustomersRepository
{
    Guid Create(Customer customer);
    Customer? GetByDocument(string document);
    IEnumerable<Customer> GetAll();
    void Update(Customer customer);
}