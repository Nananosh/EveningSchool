using System.Collections;
using EveningSchool.Models;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Business.Interfaces
{
    public interface IScheduleService
    {
        public IEnumerable GetLessonsByTeacherId(int id);
        public IEnumerable GetAllClasses();
        public IEnumerable GetAllSubjects();
        public IEnumerable GetAllCabinets();
        public IEnumerable GetAllStudents();
        public IEnumerable GetAllTeachers();
        public Lesson AddTeacherLessons(Lesson lesson);
    }
}