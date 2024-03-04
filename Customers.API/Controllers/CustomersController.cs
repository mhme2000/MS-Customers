using System.Net;
using Microsoft.AspNetCore.Mvc;
using Customers.Application.Interfaces.Customers;
using Customers.Domain.DTOs;

namespace Customers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ICreateCustomerUseCase _createCustomerUseCase;
    private readonly IGetCustomerByDocumentUseCase _getCustomerByDocumentUseCase;
    public CustomersController(ICreateCustomerUseCase createCustomerUseCase, IGetCustomerByDocumentUseCase getCustomerByDocumentUseCase)
    {
        _createCustomerUseCase = createCustomerUseCase;
        _getCustomerByDocumentUseCase = getCustomerByDocumentUseCase;
    }

    [HttpGet]
    public IActionResult GetCustomer([FromQuery] string document)
    {
        var customer = _getCustomerByDocumentUseCase.Execute(document);
        return Ok(customer);
    }

    [HttpPost]
    public IActionResult CreateCustomer([FromBody] CustomerDTO dto)
    {
        var id = _createCustomerUseCase.Execute(dto);
        Response.Headers.Location = $"/customers/{id}";
        return new ObjectResult(id.ToString()){StatusCode = (int)HttpStatusCode.Created};
    }
}
