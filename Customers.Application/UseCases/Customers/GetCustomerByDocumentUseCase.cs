using Customers.Application.Interfaces.Customers;
using Customers.Domain.DTOs;
using Customers.Domain.Interfaces;

namespace Customers.Application.UseCases.Customers;

public class GetCustomerByDocumentUseCase : IGetCustomerByDocumentUseCase
{
    private readonly ICustomersRepository _customersRepository;

    public GetCustomerByDocumentUseCase(ICustomersRepository customersRepository)
    {
        _customersRepository = customersRepository;
    }

    public CustomerDTO Execute(string document)
    {
        var customer = _customersRepository.GetByDocument(document);
        return new CustomerDTO
        {
            Document = customer.Document,
            Email = customer.Email,
            Name = customer.Name
        };
    }
}