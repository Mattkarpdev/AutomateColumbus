
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;
using ACapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ACAPPContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ACAPPContext") ?? throw new InvalidOperationException("Connection string 'ACAPPContext' not found.")));

// Add services to the container.


    builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRateLimiter(rateLimiterOptions =>
{
    rateLimiterOptions.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

    rateLimiterOptions.AddTokenBucketLimiter(policyName:"token", options =>
        {
            options.TokenLimit = 10;
            options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
            options.QueueLimit = 0;
            options.ReplenishmentPeriod = TimeSpan.FromSeconds(60);
            options.TokensPerPeriod = 10;
            options.AutoReplenishment = true;
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

app.UseRouting();
app.UseStaticFiles();
app.UseCookiePolicy();


app.UseHttpsRedirection();


app.UseAuthorization();






//app.MapDefaultControllerRoute().RequireRateLimiting("token");

app.MapControllers();
app.UseRateLimiter();
app.Run();
