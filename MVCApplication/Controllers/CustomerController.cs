using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_DAL;
using MvcApplication_EL;

namespace MVCApplication.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult IndexPassingData()
        {
            IEnumerable<Customer> customers = new CustomerRepository().AddDetails();
            ViewBag.CustomerDetails = customers;
            TempData["customers"] = customers;
            ViewData["customers"] = customers;
            return View();
        }
    }
}