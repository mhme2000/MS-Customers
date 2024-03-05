using Customers.Domain.DTOs;

namespace Customers.Application.Interfaces.Customers;

public interface IDeleteCustomerUseCase : IUseCase<object?, CustomerDTO>
{
}