using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ELearningSystem.Repository
{
    public class CourseRepository : DbContext
    {
        public CourseRepository() : base ("CourseRepository")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        //public Course GetCourse(int courseid)
        //{
        //    return QueryFirst<Course>("public.getCourse", new { courseid = courseid });
        //}

        //public List<Course> GetAllCourses()
        //{
        //    return QueryMultiple<Course>("public.getAllCourses", null);
        //}

        //public Course InsertCourse(string name, string summary)
        //{
        //    return QueryFirst<Course>("public.insertcourse", new { name = name, summary = summary });
        //}

        //public Course UpdateCourse(int courseid, string coursename, string coursesummary)
        //{
        //    return QueryFirst<Course>("public.updatecourse", new { courseid = courseid, coursename = coursename, coursesummary = coursesummary });
        //}

        //public Course DeleteCourse(int courseid)
        //{
        //    return QueryFirst<Course>("public.deletecourse", new { courseid = courseid });
        //}
    }
}
