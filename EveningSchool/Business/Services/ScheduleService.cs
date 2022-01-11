using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using EveningSchool.Models;
using EveningSchool.ViewModels.Admin;
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

        public List<Class> GetAllClasses()
        {
            var classes = db.Classes.ToList();
            return classes;
        }

        public List<Subject> GetAllSubjects()
        {
            var subjects = db.Subjects.ToList();
            return subjects;
        }

        public List<Cabinet> GetAllCabinets()
        {
            var cabinets = db.Cabinets.OrderBy(x => x.CabinetNumber).ToList();
            return cabinets;
        }

        public List<Student> GetAllStudents()
        {
            var students = db.Students
                .Include(c => c.Class).ToList();
            return students;
        }

        public List<Teacher> GetAllTeachers()
        {
            var teachers = db.Teachers.ToList();
            return teachers;
        }


        public Lesson AddTeacherLesson(Lesson lesson)
        {
            db.Lessons.Add(lesson);
            db.SaveChanges();
            var addedLesson = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .FirstOrDefault(l => l.Id == lesson.Id);
            return addedLesson;
        }

        public Lesson EditTeacherLesson(Lesson lesson)
        {
            var editLesson = db.Lessons.FirstOrDefault(x => x.Id == lesson.Id);
            if (editLesson != null)
            {
                editLesson.RecurrenceRule = lesson.RecurrenceRule;
                editLesson.CabinetId = lesson.CabinetId;
                editLesson.SubjectId = lesson.SubjectId;
                editLesson.ClassId = lesson.ClassId;
                db.SaveChanges();
            }

            var editedLesson = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .FirstOrDefault(l => l.Id == editLesson.Id);
            return editedLesson;
        }

        public void DeleteLesson(Lesson lesson)
        {
            var deleteLesson = db.Lessons.FirstOrDefault(x => x.Id == lesson.Id);
            if (deleteLesson != null) db.Lessons.Remove(deleteLesson);
            db.SaveChanges();
        }

        public IEnumerable GetLessonsByClassId(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Class.Id == id);

            return lessons;
        }

        public IEnumerable GetLessonsByCabinetId(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Cabinet.Id == id);

            return lessons;
        }

        public IEnumerable GetLessonsBySubjectId(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Subject.Id == id);

            return lessons;
        }
    }
}