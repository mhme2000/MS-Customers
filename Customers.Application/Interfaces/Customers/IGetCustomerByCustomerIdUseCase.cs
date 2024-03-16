using Customers.Domain.DTOs;

namespace Customers.Application.Interfaces.Customers;

public interface IGetCustomerByCustomerIdUseCase : IUseCase<CustomerDTO?, Guid>
{
}