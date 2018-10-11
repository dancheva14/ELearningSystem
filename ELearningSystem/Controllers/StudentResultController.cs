using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ELearningSystem.Services;
using ELearningSystem.Model;

namespace ELearningSystem.Controllers
{
    public class StudentResultController : Controller
    {
        public TestService testService = new TestService();
        public ActionResult Index(TestResult tests = null)
        {
            if (String.IsNullOrEmpty(tests.TestName))
            {
                if (User.Identity.IsAuthenticated)
                {
                    var student = Session["User"] as Student;
                    string sortColumn = "date";
                    if (student != null)
                    {
                        var testResult = testService.GetStudentResults(student.Id, sortColumn);
                        if (testResult.Count() == 0)
                        {
                            string noResult = "Ученикът още няма оценки в историята си.";
                            ViewBag.Message = noResult;
                        }
                        return View(testResult);
                    }
                }
                return RedirectToAction("Login", "UserRegistration");
            }
            else
            {
                return View(tests);
            }
        }

        [HttpGet]
        public ActionResult IndexDate()
        {
            var student = Session["User"] as Student;
            var sortedTests = testService.GetStudentResults(student.Id, "date");
            return View("Index", sortedTests);
        }

        [HttpGet]
        public ActionResult IndexName()
        {
            var student = Session["User"] as Student;
            var sortedTests = testService.GetStudentResults(student.Id, "title");
            return View("Index", sortedTests);
        }
	}
}