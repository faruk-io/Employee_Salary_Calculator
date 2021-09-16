using EmployeeSalaryCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeSalaryCalculator.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View(new salary());
        }

        [HttpPost]
        public ActionResult Index(salary s)
        {
            if(s.sal > 50000)
            {
                s.tax = s.sal * 10 / 100;
            }
            else if(s.sal >30000)
            {
                s.tax = s.sal * 5 / 100;
            }
            else
            {
                s.tax = 0;
            }
            s.nsal = s.sal - s.tax;
            return View(s);
        }
    }
}