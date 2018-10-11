using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ELearningSystem.Services;
using ELearningSystem.Model;
using System.Web.Security;

namespace ELearningSystem.Controllers
{
    public class CoursesController : Controller
    {

        private CourseService courseService = new CourseService();

        [Authorize]
        public ActionResult Index()
        {
            var model = courseService.GetAllCourses();
            return View(model);
        }

        [HttpGet]
        public ActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
            courseService.InsertCourse(course);
            return RedirectToAction("Index", "Courses");
        }


        [HttpGet]
        public ActionResult Edit(Course course, int number = 0)
        {
            var model = courseService.GetCourse(course.Id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            courseService.UpdateCourse(course);
            return RedirectToAction("Index", "Courses");
        }

        [HttpGet]
        public ActionResult Delete(Course course)
        {
            courseService.DeleteCourse(course);
            return RedirectToAction("Index", "Courses");
        }

        public ActionResult Details(int courseId)
        {
            var model = courseService.GetCourse(courseId);
            return PartialView("_Information", model);
        }
    }
}
