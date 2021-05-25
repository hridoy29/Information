using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Information.Class;
using Information.Models;

namespace Information.Controllers
{
    public class HomeController : Controller
    {
        private DataAccessLayer dataAccessLayer = new DataAccessLayer();
       
        
        [HttpGet]
        public ActionResult Index(List<Employee> empDetails)
        {
            List<Employee> emp =  (List<Employee>)TempData["Employee"];
            return View(emp);
        }

        public ActionResult EmployeeInfo(int Id)
        {
            using (BSEntities context = new BSEntities())
            {
                IEnumerable<Employee> empDetails = dataAccessLayer.EmployeeInfo(Id);
                TempData["Employee"] = empDetails;
                return RedirectToAction("Index", "Home", empDetails);
            }
           
            
        }
    }
}

//    @*@foreach (var item in (List<Information.Models.Employee>)ViewData["Employee"])*@