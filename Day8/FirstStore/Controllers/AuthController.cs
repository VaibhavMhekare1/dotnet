using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstStore.Models;
namespace FirstStore.Controllers;


public class AuthController : Controller
{ 
    
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
    public IActionResult SignUp(string name, string email, string pass)
    {
        EmployeeManager.AddEmployee(new Employee(name, email, pass));
        return View();

    }
    public IActionResult Welcome()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Validate(string email, string password)
    {
        
        List<Employee> emp=EmployeeManager.GetAllEmployees();
        
        Employee newemp = new Employee(email, password);

        if (emp.Contains(newemp))
        {
            return Redirect("/Auth/Welcome");
        }
        return Redirect("/Home/Privacy");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}