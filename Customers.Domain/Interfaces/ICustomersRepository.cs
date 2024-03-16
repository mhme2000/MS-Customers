using Customers.Domain.Entities;

namespace Customers.Domain.Interfaces;

public interface ICustomersRepository
{
    Guid Create(Customer customer);
    Customer? GetByDocument(string document);
    Customer? GetById(Guid id);
    IEnumerable<Customer> GetAll();
    void Update(Customer customer);
}