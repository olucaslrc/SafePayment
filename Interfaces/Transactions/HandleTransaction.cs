using Microsoft.AspNetCore.Mvc;
using SafePayment.Models;

namespace SafePayment.Interfaces.Transactions;

public interface IHandleTransaction
{
    IActionResult Handle(Transaction transaction);
}