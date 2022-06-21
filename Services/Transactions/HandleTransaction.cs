using Microsoft.AspNetCore.Mvc;
using SafePayment.Interfaces.Transactions;
using SafePayment.Models;

namespace SafePayment.Services.Transactions;

public class HandleTransaction : IHandleTransaction
{
    private readonly ValidateTransaction validateTransaction = new ValidateTransaction();
    public IActionResult Handle(Transaction transaction)
    {
        if (validateTransaction.Validate(transaction))
            return new StatusCodeResult(200);
        else
            return new StatusCodeResult(401);
    }
}