using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ELearningSystem.Model
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "strCourseName", ResourceType = typeof(Resources.Resource))]
        public string Name { get; set; }

        [Display(Name = "strCourseContent", ResourceType = typeof(Resources.Resource))]
        public string Summary { get; set; }

        public ICollection<Lecture> LectureList { get; set; }
    }
}
