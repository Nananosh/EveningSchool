using System.Collections;
using System.Linq;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using EveningSchool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EveningSchool.Business.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly ApplicationContext db;

        public ScheduleService(ApplicationContext db)
        {
            this.db = db;
        }

        public IEnumerable GetLessonsByTeacherId(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Teacher.Id == id);
            
            return lessons;
        }

        public IEnumerable GetAllClasses()
        {
            var classes = db.Classes;
            return classes;
        }

        public IEnumerable GetAllSubjects()
        {
            var subjects = db.Subjects;
            return subjects;
        }

        public IEnumerable GetAllCabinets()
        {
            var cabinets = db.Cabinets;
            return cabinets;
        }

        public Lesson AddTeacherLessons(Lesson lesson)
        {
            db.Lessons.Add(lesson);
            db.SaveChanges();
            var newLesson = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .FirstOrDefault(l => l.Id == lesson.Id);
            return lesson;
        }
    }
}