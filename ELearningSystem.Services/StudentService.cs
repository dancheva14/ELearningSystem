using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearningSystem.Repository;
using ELearningSystem.Model;

namespace ELearningSystem.Services
{
    public class StudentService
    {
        private StudentRepository studentRepository;

        public StudentService()
        {
            studentRepository = new StudentRepository();
        }

        public Student GetUserByNameAndPass(Student student)
        {
            return studentRepository.GetUser(student.UserName, student.Password);
        }

        public List<Student> GetAllStudents()
        {
            return studentRepository.GetAllStudents();
        }
        public Student UpdatStudent(Student student)
        {
            return studentRepository.UpdateStudent(student);
        }


        public Student InsertStudent(Student student)
        {
            return studentRepository.InsertStudent
                    (student.UserName, 
                     student.Password, 
                     student.FullName,
                     student.Email);
        }
    }
}
