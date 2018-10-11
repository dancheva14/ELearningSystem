using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearningSystem.Model;

namespace ELearningSystem.Repository
{
    public class TestRepository : BaseRepository
    {
        public Test GetTest(int testid)
        {
            return QueryFirst<Test>("public.getTest", new { testid = testid });
        }

        public List<Test> GetAllTests(int courseid)
        {
            return QueryMultiple<Test>("public.getAllTests", new { courseid = courseid });
        }

        public List<Question> GetTestQuestions(int testid)
        {
            return QueryMultiple<Question>("public.getTestQuestions", new { testid = testid });
        }

        public List<Answer> GetQuestionAnswers(int questionid)
        {
            return QueryMultiple<Answer>("public.getquestionanswers", new { questionid = questionid });
        }

        public TestResult InsertResult(int testid, int studentid, string grade)
        {
            return QueryFirst<TestResult>("public.insertresult", new
            {
                testid = testid,
                studentid = studentid,
                grade = grade
            });
        }

        public List<TestResult> GetStudentResults(int studentid, string sortcolumn)
        {
            return QueryMultiple<TestResult>("public.getstudentresults", new { studentid = studentid, sortcolumn = sortcolumn });
        }
    }
}
