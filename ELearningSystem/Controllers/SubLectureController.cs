using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ELearningSystem.Services;

namespace ELearningSystem.Controllers
{
    public class SubLectureController : Controller
    {
        private LectureService lectureService = new LectureService();

        [Authorize]
        public ActionResult Index(int id)
        {
            var model = lectureService.GetLecture(id);
            if (model == null)
                return View();
            else
                return View(model);
        }
	}
}