using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.Food = new List<string>()
            {
                "pizza",
                "burger",
                "parotta"
            };
            return View();
        }
    }
}