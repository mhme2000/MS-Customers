using Customers.Domain.DTOs;

namespace Customers.Application.Interfaces.Customers;

public interface IGetCustomerByDocumentUseCase : IUseCase<CustomerDTO, string>
{
}