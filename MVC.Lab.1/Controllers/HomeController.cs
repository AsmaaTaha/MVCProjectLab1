using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Lab._1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
        List<Employee> loe = new List<Employee>
          {
              new Employee("asmaa",22,10000),
              new Employee("sara",20,90000),
              new Employee("heba",30,678),
              new Employee("shery",24,5678),
              new Employee("gehad",25,567),
              new Employee("nourhan",24,5678),
              new Employee("radwa",20,23456),
              new Employee("menna",20,5678),
              new Employee("mohamed",19,7890),
              new Employee("ahmed",27,2345)
          };
            return View(loe);
        }
    }
} 