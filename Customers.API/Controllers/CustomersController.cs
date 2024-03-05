using System.Net;
using Microsoft.AspNetCore.Mvc;
using Customers.Application.Interfaces.Customers;
using Customers.Domain.DTOs;

namespace Customers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController(ICreateCustomerUseCase createCustomerUseCase, IGetCustomerByDocumentUseCase getCustomerByDocumentUseCase, IGetCustomersUseCase getCustomersUseCase, IDeleteCustomerUseCase deleteCustomerUseCase) : ControllerBase
{
    private readonly ICreateCustomerUseCase _createCustomerUseCase = createCustomerUseCase;
    private readonly IGetCustomerByDocumentUseCase _getCustomerByDocumentUseCase = getCustomerByDocumentUseCase;
    private readonly IGetCustomersUseCase _getCustomersUseCase = getCustomersUseCase;
    private readonly IDeleteCustomerUseCase _deleteCustomerUseCase = deleteCustomerUseCase;

    [HttpGet]
    public IActionResult GetCustomers()
    {
        var customers = _getCustomersUseCase.Execute(new object { });
        return Ok(customers);
    }

    [HttpGet]
    public IActionResult GetCustomer([FromQuery] string document)
    {
        var customer = _getCustomerByDocumentUseCase.Execute(document);
        if (customer == null) return NotFound("Customer not found.");
        return Ok(customer);
    }

    [HttpPost]
    public IActionResult CreateCustomer([FromBody] CustomerDTO dto)
    {
        var id = _createCustomerUseCase.Execute(dto);
        if (id == null) return BadRequest("Customer already exists.");
        Response.Headers.Location = $"/customers/{id}";
        return new ObjectResult(id.ToString()){StatusCode = (int)HttpStatusCode.Created};
    }

    [HttpDelete]
    public IActionResult DeleteCustomer([FromBody] CustomerDTO dto)
    {
        var result = _deleteCustomerUseCase.Execute(dto);
        if (result == null) return NotFound("Customer not found.");
        return NoContent();
    }
}
