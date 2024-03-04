using Microsoft.EntityFrameworkCore;
using Customers.Domain.Entities;

namespace Customers.Infrastructure.Contexts;

public class CustomersContext(DbContextOptions<CustomersContext> options) : DbContext(options)
{
    public DbSet<Customer> Customer { get; set; } = null!;
}