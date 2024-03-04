using Microsoft.EntityFrameworkCore;
using Customers.Domain.Entities;

namespace Customers.Infrastructure.Contexts;

public class CustomersContext : DbContext
{
    public CustomersContext(DbContextOptions<CustomersContext> options): base(options){}
    public DbSet<Customer>? Customer { get; set; }
}