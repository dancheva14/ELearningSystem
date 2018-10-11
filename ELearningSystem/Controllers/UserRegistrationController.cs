using System.Web.Mvc;
using ELearningSystem.Model;
using System.Web.Security;
using ELearningSystem.Services;
using System;
using System.Collections.Generic;

namespace ELearningSystem.Controllers
{
    public class UserRegistrationController : Controller
    {
        public Student User
        {
            get
            {
                return Session["USER"] as Student;
            }

            set
            {
                Session["USER"] = value;
            }
        }


        public StudentService studentService = new StudentService();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Login(Student student, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (!String.IsNullOrEmpty(student.UserName))
                {
                    var authenticatedUser = studentService.GetUserByNameAndPass(student);
                    if (authenticatedUser != null)
                    {
                        return HandleSuccessfulLogin(authenticatedUser, returnUrl);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Потребителското име и/или паролата са невалидни. Опитайте отново.");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Login data is incorrect");
            }
            return View(student);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.Email == null)
                    student.Email = string.Empty;
                studentService.InsertStudent(student);
                return RedirectToAction("Login", "UserRegistration");
            }
            return View();
        }

        [HttpGet]
        public ActionResult AddRole()
        {
            var students = studentService.GetAllStudents();
            return View(students);
        }

        [HttpPost]
        public ActionResult AddRole(List<Student> students)
        {
            foreach(var student in students)
            {
                studentService.UpdatStudent(student);
            }            
            return RedirectToAction("Index", "Home");
        }

        private ActionResult HandleSuccessfulLogin(Student user, string returnUrl)
        {
            User = user;

            //FormsAuthentication.SetAuthCookie
            FormsAuthentication.SetAuthCookie(user.UserName, false);

            if (!string.IsNullOrEmpty(returnUrl))
            {
                returnUrl = returnUrl.Trim('\'');

                var decoded = Server.UrlDecode(returnUrl);
                if (Url.IsLocalUrl(decoded))
                {
                    return Redirect(returnUrl);
                }
            }

            return RedirectToAction("Index", "Home", null);
        }

    }
}
