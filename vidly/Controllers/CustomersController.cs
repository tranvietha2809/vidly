using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        IEnumerable<Customer> CustomerList = new List<Customer>
        {
            new Customer {Id = 1, Name = "John Smith"},
            new Customer {Id = 2, Name = "Mary William"}
        };

        // GET: Customers
        
        public ActionResult Index()
        {
            return View(CustomerList);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            foreach (var customer in CustomerList)
            {
                if (customer.Id == id)
                {
                    return View(customer);
                }
            }
            return HttpNotFound();
        }
        /**private IEnumerable<Customer> GetCustomers()
        {
                return new List<Customer> 
                {
                    new Customer {Name = "John Smith", Id = 1 },
                    new Customer { Name = "Mary Williams", Id = 2 }
                };
        };**/
    }
}