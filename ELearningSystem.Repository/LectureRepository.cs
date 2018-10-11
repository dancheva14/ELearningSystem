using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearningSystem.Model;

namespace ELearningSystem.Repository
{
    public class LectureRepository : BaseRepository
    {
        public Lecture GetLecture(int lectureid)
        {
            return QueryFirst<Lecture>("public.getlecture", new { lectureid = lectureid });
        }

        public List<Lecture> GetAllLectures(int courseid)
        {
            return QueryMultiple<Lecture>("public.getalllecturesforcurrentcourse", new { courseid = courseid });
        }

        public Lecture InsertLecture(int courseid, string title, string content)
        {
            return QueryFirst<Lecture>("public.insertlecture", new { courseid = courseid, title = title, content = content });
        }

        public Lecture UpdateLecture(int lectureid, string lecturetitle, string lecturecontent)
        {
            return QueryFirst<Lecture>("public.updatelecture",
                                      new { lectureid = lectureid, lecturetitle = lecturetitle, lecturecontent = lecturecontent });
        }

        public Lecture DeleteLecture(int lectureid)
        {
            return QueryFirst<Lecture>("public.deletelecture",
                                      new { lectureid = lectureid });
        }
    }
}
