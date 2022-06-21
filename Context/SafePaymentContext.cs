using Microsoft.EntityFrameworkCore;
using SafePayment.Models;

namespace SafePayment.Context;

public class SafePaymentContext : DbContext
{
    public SafePaymentContext(DbContextOptions<SafePaymentContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().ToTable("Customer");
        modelBuilder.Entity<Transaction>().ToTable("Transaction");
    }
}