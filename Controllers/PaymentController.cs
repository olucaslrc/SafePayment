using Microsoft.AspNetCore.Mvc;
using SafePayment.Models;
using SafePayment.Services.Transactions;

namespace SafePayment.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentController : ControllerBase
{
    private readonly HandleTransaction handleTransaction = new HandleTransaction();
    private readonly ILogger<PaymentController> _logger;
    public PaymentController(ILogger<PaymentController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [Route("transaction")]
    public IActionResult Transaction(Transaction transaction)
    {
        return handleTransaction.Handle(transaction);
    }
}
