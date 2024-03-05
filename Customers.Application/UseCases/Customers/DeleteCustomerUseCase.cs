using Customers.Application.Interfaces.Customers;
using Customers.Domain.DTOs;
using Customers.Domain.Interfaces;

namespace Customers.Application.UseCases.Customers;

public class DeleteCustomerUseCase(ICustomersRepository customersRepository) : IDeleteCustomerUseCase
{
    private readonly ICustomersRepository _customersRepository = customersRepository;

    public object? Execute(CustomerDTO dto)
    {
        var customer = _customersRepository.GetByDocument(dto.Document);
        if (customer == null) return null;
        customer.Email = "xxxx@xxxxx.com";
        customer.Document = "xxxxxxxxxxx";
        customer.Address = null;
        customer.Phone = null;
        customer.IsDeleted = true;
        _customersRepository.Update(customer);
        return customer;
    }
}
