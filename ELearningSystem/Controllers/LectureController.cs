using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ELearningSystem.Services;
using ELearningSystem.Model;

namespace ELearningSystem.Controllers
{
    public class LectureController : Controller
    {
        private LectureService lectureService = new LectureService();
        private CourseService courseService = new CourseService();
        List<Course> courseModel = new List<Course>();
        private const string COURSEIDKEY = "COURSEIDKEY";
        private string noResult = string.Empty;

        public string CourseId
        {
            get
            {
                return Session[COURSEIDKEY] as string;
            }
            set
            {
                Session[COURSEIDKEY] = value;
            }
        }


        public ActionResult Index(int id = 0)
        {
            if (id > 0)
            {
                CourseId = id.ToString();
                courseModel.Add(courseService.GetCourse(id));
                courseModel[0].LectureList = lectureService.GetAllLectures(id);
                courseModel[0].LectureList.ForEach(l => l.CourseId = id);
                if (courseModel[0].LectureList.Count() == 0)
                {
                    noResult = "За този курс още няма въведени лекции.";
                    ViewBag.Message = noResult;
                }
                id = 0;
                return View(courseModel);
            }
            else
            {
                courseModel = courseService.GetAllCourses();
                for (int i = 0; i < courseModel.Count(); i++)
                {
                    var lectures = lectureService.GetAllLectures(courseModel[i].Id);
                    lectures.ForEach(l => l.CourseId = id);
                    courseModel[i].LectureList = lectures;
                }
                id = 0;
                return View(courseModel);
            }
        }

        [HttpGet]
        public ActionResult LectureList()
        {
            courseModel = courseService.GetAllCourses();
            for (int i = 0; i < courseModel.Count(); i++)
            {
                var lectures = lectureService.GetAllLectures(courseModel[i].Id);
                courseModel[i].LectureList = lectures;
            }
            return View(courseModel);
        }


        [HttpPost]
        public ActionResult Index(Model.Course model)
        {
            var courseModel = courseService.GetAllCourses();
            return View(courseModel);
        }

        [HttpGet]
        public ActionResult AddLecture(int courseId, bool isPartial = false)
        {
            if (isPartial)
            {
                return PartialView(new Lecture { CourseId = courseId });
            }

            return View(new Lecture { CourseId = courseId });
        }

        [HttpPost]
        public ActionResult AddLecture(Lecture lecture)
        {
            lectureService.InsertLecture(lecture);
            return RedirectToAction("LectureList", "Lecture");
        }

        [HttpGet]
        public ActionResult Edit(Lecture lecture)
        {
            var model = lectureService.GetLecture(lecture.Id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Lecture lecture,int number = 0)
        {
            lectureService.UpdateLecture(lecture);
            return RedirectToAction("LectureList", "Lecture");
        }

        [HttpGet]
        public ActionResult Delete(Lecture lecture)
        {
            lectureService.DeleteLecture(lecture);
            return RedirectToAction("LectureList", "Lecture");
        }

        public ActionResult GetCoursesDropdown()
        {
            var courses = courseService.GetAllCourses();
            return View("CoursesDropdown", courses);
        }
    }
}