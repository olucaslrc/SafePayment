using System.ComponentModel.DataAnnotations;

namespace SafePayment.Models;

public class Transaction
{
    [Required]
    public long Id { get; set; }
    public Customer? Customer { get; set; }
    public double Amount { get; set; }
    public PaymentType Type { get; set; }
    public bool TransactionComplete { get; set; }
    public string? Token { get; set; }
}