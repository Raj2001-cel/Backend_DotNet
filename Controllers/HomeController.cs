using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dotnet_backend.Models;
using MySqlConnector;
using System;
namespace Dotnet_backend.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
    {
        _logger = logger;
      Configuration = configuration;
    }

 public IConfiguration Configuration { get; }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        using var connection = new MySqlConnection(Configuration.GetConnectionString("Default"));
        connection.Open();
        Console.WriteLine($"con object --- {connection}");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
