using Microsoft.AspNetCore.Mvc;
using SafePayment.Models;

namespace SafePayment.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;

    public CustomerController(ILogger<CustomerController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult? Transaction(Transaction transaction)
    {
        return null;
    }
}
