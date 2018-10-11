using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearningSystem.Model
{
    public class TestResult
    {
        public int Id { get; set; }
        public int CorrectAnswers { get; set; }

        public int WrongAnswers { get; set; }

        public int EmptyAnswers { get; set; }

        public int Procent { get; set; }

        public string Status { get; set; }

        public string TestName { get; set; }

        public string StudentName { get; set; }

        public string Grade { get; set; }

        public DateTime Date { get; set; }
    }
}
