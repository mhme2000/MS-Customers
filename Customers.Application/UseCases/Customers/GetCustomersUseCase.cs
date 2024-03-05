using Customers.Application.Interfaces.Customers;
using Customers.Domain.DTOs;
using Customers.Domain.Interfaces;

namespace Customers.Application.UseCases.Customers;

public class GetCustomersUseCase(ICustomersRepository customersRepository) : IGetCustomersUseCase
{
    private readonly ICustomersRepository _customersRepository = customersRepository;

    public IEnumerable<CustomerDTO> Execute(object request)
    {
        var customers = _customersRepository.GetAll();
        foreach (var customer in customers)
        {
            yield return new CustomerDTO
            {
                Document = customer.Document,
                Email = customer.Email,
                Name = customer.Name
            };
        } 
    }
}