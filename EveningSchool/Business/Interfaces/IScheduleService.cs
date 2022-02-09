using System;
using System.Collections;
using System.Collections.Generic;
using EveningSchool.Models;
using EveningSchool.ViewModels.Admin;
using EveningSchool.ViewModels.Schedule;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Business.Interfaces
{
    public interface IScheduleService
    {
        public IEnumerable GetLessonsByTeacherId(int id);
        public List<Class> GetAllClasses();
        public List<Class> GetAllClasses(int lessonNumber, DateTime dateStart);
        public List<Subject> GetAllSubjects();
        public List<Cabinet> GetAllCabinets();
        public List<Cabinet> GetAllCabinets(int lessonNumber, DateTime dateStart);
        public List<Student> GetAllStudents();
        public List<Teacher> GetAllTeachers();
        public Lesson AddTeacherLesson(Lesson lesson);
        public Lesson EditTeacherLesson(Lesson lesson);
        public void DeleteLesson(Lesson lesson);
        public IEnumerable GetLessonsByClassId(int id);
        public IEnumerable GetLessonsByCabinetId(int id);
        public IEnumerable GetLessonsBySubjectId(int id);
    }
}