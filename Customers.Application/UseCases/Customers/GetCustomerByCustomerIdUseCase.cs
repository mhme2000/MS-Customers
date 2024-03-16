using Customers.Application.Interfaces.Customers;
using Customers.Domain.DTOs;
using Customers.Domain.Interfaces;

namespace Customers.Application.UseCases.Customers;

public class GetCustomerByCustomerIdUseCase(ICustomersRepository customersRepository) : IGetCustomerByCustomerIdUseCase
{
    private readonly ICustomersRepository _customersRepository = customersRepository;

    public CustomerDTO? Execute(Guid customerId)
    {
        var customer = _customersRepository.GetById(customerId);
        if (customer == null) return null;
        return new CustomerDTO
        {
            Document = customer.Document,
            Email = customer.Email,
            Name = customer.Name
        };
    }
}