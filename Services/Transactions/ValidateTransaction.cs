using SafePayment.Context;
using SafePayment.Models;
using System.Security.Cryptography;

namespace SafePayment.Services.Transactions;

public class ValidateTransaction
{
    private readonly VerifyCredentials verifyCredentials = new VerifyCredentials();
    private readonly SafePaymentContext _context;
    public bool Validate(Transaction transaction)
    {
        var isValid = false;

        if (verifyCredentials.Verify(transaction.Customer))
            _context.Add<Transaction>(new Transaction {
                Customer = transaction.Customer,
                Amount = transaction.Amount,
                Type = transaction.Type,
                TransactionComplete = true,
                Token = transaction.GetHashCode().ToString()
            });
            _context.SaveChanges();
            isValid = true;

        return isValid;
    }
}