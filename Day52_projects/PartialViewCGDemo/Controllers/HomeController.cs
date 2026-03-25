using Microsoft.AspNetCore.Mvc;
using PartialViewCGDemo.Models;
using System.Diagnostics;

namespace PartialViewCGDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        Employee emp = new Employee()
        {
            EmpID = 101,
            EmpName = "ravi",
            Email= "tanya",
            Description= "student"

        };

        public IActionResult displayemp()
        {
            return View(emp);
        }

        public ActionResult DisplayAllEmp()
        {
            List<Employee> emplist = new List<Employee>()
           {
               new Employee{EmpID=101,EmpName="raghavendra ponde",Email="raghuponde@yahoo.com"
               ,Description="I am freelance trainer etc an etcI am freelance trainer etc an etcI am" +
   " freelance trainer etc an etcI am freelance trainer etc an etcI am" +
" freelance trainer etc an etcI am freelance trainer etc an etc" },

               new Employee{EmpID=102,EmpName="suresh",Email="suresh@yahoo.com"
               ,Description="I am freelance trainer etc an etcI am freelance trainer etc an etcI am" +
   " freelance trainer etc an etcI am freelance trainer etc an etcI am" +
" freelance trainer etc an etcI am freelance trainer etc an etc" },

               new Employee{EmpID=103,EmpName="kiran",Email="kiran@yahoo.com"
               ,Description="I am freelance trainer etc an etcI am freelance trainer etc an etcI am" +
   " freelance trainer etc an etcI am freelance trainer etc an etcI am" +
" freelance trainer etc an etcI am freelance trainer etc an etc" },

               new Employee{EmpID=104,EmpName="mahesh",Email="mahesh@yahoo.com"
               ,Description="I am freelance trainer etc an etcI am freelance trainer etc an etcI am" +
   " freelance trainer etc an etcI am freelance trainer etc an etcI am" +
" freelance trainer etc an etcI am freelance trainer etc an etc" }

           };


            return View(emplist);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
