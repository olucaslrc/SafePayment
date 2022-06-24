using Microsoft.EntityFrameworkCore;
using SafePayment.Models;

namespace SafePayment.Context;

public class SafePaymentContext : DbContext
{
    public SafePaymentContext(DbContextOptions<SafePaymentContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().ToTable("Customer");
        modelBuilder.Entity<Transaction>().ToTable("Transaction");
    }
}