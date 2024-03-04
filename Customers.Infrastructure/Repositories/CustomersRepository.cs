using Customers.Domain.Entities;
using Customers.Domain.Interfaces;
using Customers.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Customers.Infrastructure.Repositories;

public class CustomersRepository : ICustomersRepository
{
    private readonly CustomersContext _context;

    public CustomersRepository(CustomersContext context)
    {
        _context = context;
    }
    public Guid Create(Customer customer)
    {
        _context.Customer.Add(customer);
        _context.SaveChanges();
        return customer.Id;
    }

    public Customer GetByDocument(string document)
    {
        return _context.Customer.AsNoTracking().FirstOrDefault(t => t.Document == document);
    }
}
