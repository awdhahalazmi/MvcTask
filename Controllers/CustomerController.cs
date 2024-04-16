using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer[] customers = new Customer[]
   {
        new Customer {Id = 1, Name = "awdhah",Email = "12@gmail.com",PhoneNumber = "1234"}, new Customer {Id = 2, Name = "fatmah",Email = "12@gmail.com",PhoneNumber = "1234"}
   };
            return View(customers.ToList());
        }

    }
}

