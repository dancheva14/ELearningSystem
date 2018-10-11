using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearningSystem.Model;

namespace ELearningSystem.Repository
{
    public class StudentRepository : BaseRepository
    {
        public Student GetUser(string userName, string password)
        {
            return QueryFirst<Student>("public.getuser", new { uname = userName, pass = password });
        }

        public List<Student> GetAllStudents()
        {
            return QueryMultiple<Student>("public.getallstudents");
        }

        public Student UpdateStudent(Student student)
        {
            return QueryFirst<Student>("public.updatestudent", new { studentid = student.Id, isAdmin = student.IsAdmin });
        }

        public Student InsertStudent(string userName, string password, string fullname, string email)
        {
            return QueryFirst<Student>("public.insertstudent", new { username = userName, pass = password, fullname = fullname, email = email });
        }
    }
}
