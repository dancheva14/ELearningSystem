using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ELearningSystem.Services;

namespace ELearningSystem.Controllers
{
    public class BasePageController : Controller
    {
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }
	}
}