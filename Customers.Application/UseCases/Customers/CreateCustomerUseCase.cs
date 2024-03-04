using Customers.Application.Interfaces.Customers;
using Customers.Domain.DTOs;
using Customers.Domain.Entities;
using Customers.Domain.Interfaces;

namespace Customers.Application.UseCases.Customers;

public class CreateCustomerUseCase : ICreateCustomerUseCase
{
    private readonly ICustomersRepository _customersRepository;

    public CreateCustomerUseCase(ICustomersRepository customersRepository)
    {
        _customersRepository = customersRepository;
    }

    public Guid Execute(CustomerDTO dto)
    {
        var customer = new Customer(dto.Document, dto.Email, dto.Name);
        var id = _customersRepository.Create(customer);
        return id;
    }
}
