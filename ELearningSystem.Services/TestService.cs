using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearningSystem.Repository;
using ELearningSystem.Model;

namespace ELearningSystem.Services
{
    public class TestService
    {
        private TestRepository testRepository;

        public TestService()
        {
            testRepository = new TestRepository();
        }

        public Test GetTest(int testid)
        {
            return testRepository.GetTest(testid);
        }

        public List<Test> GetAllTests(int courseid)
        {
            return testRepository.GetAllTests(courseid).ToList();
        }
        public List<Question> GetTestQuestions(int testid)
        {
            return testRepository.GetTestQuestions(testid);
        }

        public List<Answer> GetQuestionAnswers(int questionid)
        {
            return testRepository.GetQuestionAnswers(questionid);
        }
        public TestResult InsertResult(int test_id, int student_id, string grade)
        {
            return testRepository.InsertResult(test_id, student_id, grade);
        }

        public List<TestResult> GetStudentResults(int studentid, string sortColumn)
        {
            return testRepository.GetStudentResults(studentid, sortColumn);
        }
    }
}
