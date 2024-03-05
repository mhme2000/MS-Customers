using Customers.Application.Interfaces.Customers;
using Customers.Domain.DTOs;
using Customers.Domain.Entities;
using Customers.Domain.Interfaces;

namespace Customers.Application.UseCases.Customers;

public class CreateCustomerUseCase(ICustomersRepository customersRepository) : ICreateCustomerUseCase
{
    private readonly ICustomersRepository _customersRepository = customersRepository;

    public Guid Execute(CustomerDTO dto)
    {
        var customer = new Customer(dto.Document, dto.Email, dto.Name, dto.Address, dto.Phone);
        var id = _customersRepository.Create(customer);
        return id;
    }
}
