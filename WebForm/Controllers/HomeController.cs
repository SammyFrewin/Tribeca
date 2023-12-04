using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebForm.Models;
using People;
namespace WebForm.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Success()
    {
        return View();
    }

    //Runs when a post request is sent from the website
    [HttpPost]
    public IActionResult Index(string firstName, string lastName, DateTime dob)
    {
        try{
        // Create a Person instance with the submitted data, catch any errors and write a server side error in the console
        //This could be wrriten to an error log for easier accessability during production
        Person newPerson = new Person(lastName, firstName, dob);
            //This has been changed to a successful submition screen to show user progress
            return RedirectToAction("Success");
            
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return View();
        }

        // Redirect to a success page or show a success message
       
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
