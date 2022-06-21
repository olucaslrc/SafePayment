using Microsoft.EntityFrameworkCore;
using SafePayment.Context;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddDbContext<SafePaymentContext>(x => x.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => 
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                        policy => 
                        {
                            policy.WithOrigins(
                                "http://example.com",
                                "http://contoso.com"
                            );
                        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();