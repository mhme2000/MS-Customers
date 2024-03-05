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
        if (customer.Name != dto.Name || customer.Document != dto.Document || customer.Email != dto.Email) return null;
        customer.Email = "xxxx@xxxxx.com";
        customer.Document = "xxxxxxxxxxx";
        customer.Address = null;
        customer.Phone = null;
        customer.IsDeleted = true;
        customer.AnonymizationDate = DateTime.Now;
        _customersRepository.Update(customer);
        return customer;
    }
}
