using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PSA_AB_YM_JS.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PSA_AB_YM_JSContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PSA_AB_YM_JSContext") ?? throw new InvalidOperationException("Connection string 'PSA_AB_YM_JSContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
