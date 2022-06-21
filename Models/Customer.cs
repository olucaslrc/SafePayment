using System.ComponentModel.DataAnnotations;

namespace SafePayment.Models;

public class Customer
{
    [Required]
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
}