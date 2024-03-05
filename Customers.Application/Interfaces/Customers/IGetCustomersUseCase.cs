using Customers.Domain.DTOs;

namespace Customers.Application.Interfaces.Customers;

public interface IGetCustomersUseCase : IUseCase<IEnumerable<CustomerDTO>, object>
{
}