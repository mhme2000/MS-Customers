using Customers.Domain.DTOs;

namespace Customers.Application.Interfaces.Customers;

public interface ICreateCustomerUseCase : IUseCase<Guid?, CustomerDTO>
{
}