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
        public ActionResult Index()
        {
            IEnumerable<Customer> customers = new CustomerRepository().AddDetails();
            return View(customers);
        }
        public ActionResult IndexPassingData()
        {
            IEnumerable<Customer> customers = new CustomerRepository().AddDetails();
            ViewBag.CustomerDetails = customers;
            ViewData["customers"] = customers;
            return View();
        }
        public ActionResult CheckTempData()
        {
            IEnumerable<Customer> customers = new CustomerRepository().AddDetails();
            TempData["customers"] = customers;
            return RedirectToAction("CheckingTempData");
        }
        public ActionResult CheckingTempData()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            // if(ModelState.IsValid)
            //{
            new CustomerRepository().CreateRow(customer);
            TempData["Message"] = "Customer added";
            return RedirectToAction("Index");
            //}
            //return View(packageDetails);
        }
        public ActionResult Edit(int id)
        {
            Customer customer = new CustomerRepository().GetCustomerById(id);
            return View(customer);
        }
        public ActionResult Delete(int id)
        {
            new CustomerRepository().DeleteCustomer(id);
            TempData["Message"] = "Customer deleted";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            // if (ModelState.IsValid)
            //{
            new CustomerRepository().UpdateCustomer(customer);
            TempData["Message"] = "Customer updated";
            return RedirectToAction("Index");
            //}
            //return View("Edit",packageDetails);
        }
    }
}