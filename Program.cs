using MySqlConnector;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

var builder = WebApplication.CreateBuilder(args);

// builder.AddJSONFile();
// var builder2 = new ConfigurationBuilder()
//     .AddJsonFile("appsettings.json");
// var config = builder2.Build();
// string connectionString = config.GetConnectionString("Default"); 


// Add services to the container.
builder.Services.AddControllersWithViews();
// builder.Services.AddTransient<MySqlConnection>(_ =>
//     new MySqlConnection(config.GetConnectionString("MyConnectionString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    


app.UseHttpsRedirection();  
app.UseStaticFiles();  
app.UseRouting();  
app.UseAuthorization();  

app.Run();
