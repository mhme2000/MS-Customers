using Customers.Application.Interfaces.Customers;
using Customers.Domain.DTOs;
using Customers.Domain.Interfaces;

namespace Customers.Application.UseCases.Customers;

public class GetCustomerByDocumentUseCase(ICustomersRepository customersRepository) : IGetCustomerByDocumentUseCase
{
    private readonly ICustomersRepository _customersRepository = customersRepository;

    public CustomerDTO? Execute(string document)
    {
        var customer = _customersRepository.GetByDocument(document);
        if (customer == null) return null;
        return new CustomerDTO
        {
            Document = customer.Document,
            Email = customer.Email,
            Name = customer.Name
        };
    }
}