using DockerAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly CustomerContext _customerContext;
    private readonly ILogger<WeatherForecastController> _logger;

    public CustomerController(CustomerContext customerContext, ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        _customerContext  = customerContext;

    }

    
    [HttpGet(Name = "GetCustomers")]
    public ActionResult<IEnumerable<Customer>> GetCustomers()
    {
        return _customerContext.Customers;
    }

}