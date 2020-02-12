using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ViewResult MarkIndex()
        {
            ViewBag.Subject = new List<string>()
            {
                "Tamil",
                "English",
                "Maths",
                "Science",
                "Social Science"
            };
            return View();
        }
    }
}