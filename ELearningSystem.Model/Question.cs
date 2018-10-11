using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearningSystem.Model
{
    public class Question
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string Comment { get; set; }

        public int Answer { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public int? RightAnswerIndex { get; set; }
    }
}
