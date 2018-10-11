using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ELearningSystem.Model
{
    public class Test
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Points { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
