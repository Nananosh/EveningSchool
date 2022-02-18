﻿using System;
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
                .Where(lesson => lesson.Teacher.Id == id && lesson.Replacement == false);

            return lessons;
        }

        public IEnumerable GetLessonsByClassIdReplaced(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Class.Id == id && lesson.Replacement == true);

            return lessons;
        }

        public IEnumerable GetLessonsByCabinetIdReplaced(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Cabinet.Id == id && lesson.Replacement == true);

            return lessons;
        }

        public IEnumerable GetLessonsBySubjectIdReplaced(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Subject.Id == id && lesson.Replacement == true);

            return lessons;
        }

        public IEnumerable GetLessonsByTeacherIdReplaced(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Teacher.Id == id && lesson.Replacement == true);

            return lessons;
        }

        public IEnumerable GetAllTeacherLessonsByTeacherId(int id)
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

        public List<Class> GetAllClasses(int lessonNumber, DateTime dateStart)
        {
            var classes = db.Classes.Where(x => !db.Lessons.Any(y =>
                y.ClassId == x.Id && y.LessonNumber == lessonNumber && y.DateStart.Date == dateStart.Date)).ToList();
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

        public List<Cabinet> GetAllCabinets(int lessonNumber, DateTime dateStart)
        {
            var cabinets = db.Cabinets
                .Where(x => !db.Lessons.Any(y =>
                    y.CabinetId == x.Id && y.LessonNumber == lessonNumber && y.DateStart.Date == dateStart.Date))
                .OrderBy(x => x.CabinetNumber).ToList();
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

        public List<Lesson> GetAllLessonsSubstitution()
        {
            var lessons = db.Lessons.Where(x => x.Replacement == true).Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher).ToList();
            return lessons;
        }


        public Lesson AddTeacherLesson(Lesson lesson)
        {
            Lesson addedLesson;
            Lesson tempLesson;
            if (lesson.CabinetId == 0 && lesson.SubjectId == 0 && lesson.ClassId == 0)
            {
                tempLesson = new Lesson
                {
                    DateEnd = lesson.DateEnd,
                    DateStart = lesson.DateStart,
                    Replacement = lesson.Replacement,
                    Delete = lesson.Delete,
                    LessonNumber = lesson.LessonNumber,
                    TeacherId = lesson.TeacherId
                };
                db.Lessons.Add(tempLesson);
                db.SaveChanges();
                addedLesson = db.Lessons
                    .Include(x => x.Cabinet)
                    .Include(x => x.Class)
                    .Include(x => x.Subject)
                    .Include(x => x.Teacher)
                    .FirstOrDefault(l => l.Id == tempLesson.Id);
            }
            else
            {
                db.Lessons.Add(lesson);
                db.SaveChanges();
                addedLesson = db.Lessons
                    .Include(x => x.Cabinet)
                    .Include(x => x.Class)
                    .Include(x => x.Subject)
                    .Include(x => x.Teacher)
                    .FirstOrDefault(l => l.Id == lesson.Id);
            }
            
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
                editLesson.LessonNumber = lesson.LessonNumber;
                editLesson.Replacement = lesson.Replacement;
                editLesson.Delete = lesson.Delete;
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
                .Where(lesson => lesson.Class.Id == id && lesson.Replacement == false);

            return lessons;
        }

        public IEnumerable GetLessonsByCabinetId(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Cabinet.Id == id && lesson.Replacement == false);

            return lessons;
        }

        public IEnumerable GetLessonsBySubjectId(int id)
        {
            var lessons = db.Lessons
                .Include(x => x.Cabinet)
                .Include(x => x.Class)
                .Include(x => x.Subject)
                .Include(x => x.Teacher)
                .Where(lesson => lesson.Subject.Id == id && lesson.Replacement == false);

            return lessons;
        }
    }
}