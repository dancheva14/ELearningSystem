using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearningSystem.Repository;
using ELearningSystem.Model;

namespace ELearningSystem.Services
{
    public class LectureService
    {
        private LectureRepository lectureRepository;

        public LectureService()
        {
            lectureRepository = new LectureRepository();
        }

        public Lecture GetLecture(int id)
        {
            return lectureRepository.GetLecture(id);
        }
        
        public List<Lecture> GetAllLectures(int courseid)
        {
            return lectureRepository.GetAllLectures(courseid);
        }
        public Lecture InsertLecture(Lecture lecture)
        {
            return lectureRepository.InsertLecture
                    (lecture.CourseId,
                     lecture.Title,
                     lecture.Content);
        }

        public Lecture UpdateLecture(Lecture lecture)
        {
            return lectureRepository.UpdateLecture
                    (lecture.Id,
                     lecture.Title,
                     lecture.Content);
        }

        public Lecture DeleteLecture(Lecture lecture)
        {
            return lectureRepository.DeleteLecture
                    (lecture.Id);
        }

    }
}
