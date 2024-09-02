using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class GridController : Controller
    {
        public IActionResult Index()
        {
            var model = GetCustomers();
            return View(model);
        }

        private List<Customer> GetCustomers()
        {
           
            var result = Enumerable.Range(0, 50).Select(i => new Customer
            {
                Id = i,
                CompanyName = "Company Name " + i,
                ContactName = "Contact Name " + i,
                ContactTitle = "Contact Title " + i,
                Country = "Coutry " + i
            });

          
            return result.ToList();
        }
    }
}
