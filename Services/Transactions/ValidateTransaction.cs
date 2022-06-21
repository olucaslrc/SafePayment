using SafePayment.Context;
using SafePayment.Models;

namespace SafePayment.Services.Transactions;

public class ValidateTransaction
{
    private readonly VerifyCredentials verifyCredentials = new VerifyCredentials();
    private readonly SafePaymentContext _context;
    public bool Validate(Transaction transaction)
    {
        var isValid = false;

        if (verifyCredentials.Verify(transaction.Customer))

            _context.Add(transaction);
            _context.SaveChanges();
            isValid = true;

        return isValid;
    }
}