using Customers.Domain.Entities;
using Customers.Domain.Interfaces;
using Customers.Infrastructure.Contexts;

namespace Customers.Infrastructure.Repositories;

public class CustomersRepository(CustomersContext context) : ICustomersRepository
{
    private readonly CustomersContext _context = context;

    public Guid Create(Customer customer)
    {
        _context.Customer.Add(customer);
        _context.SaveChanges();
        return customer.Id;
    }

    public Customer? GetByDocument(string document)
    {
        return _context.Customer.FirstOrDefault(t => t.Document == document);
    }

    public void Update(Customer customer)
    {
        _context.Customer.Update(customer);
        _context.SaveChanges();
    }
}
