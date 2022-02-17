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
        public List<Class> GetAllClasses();
        public List<Class> GetAllClasses(int lessonNumber, DateTime dateStart);
        public List<Subject> GetAllSubjects();
        public List<Cabinet> GetAllCabinets();
        public List<Cabinet> GetAllCabinets(int lessonNumber, DateTime dateStart);
        public List<Student> GetAllStudents();
        public List<Teacher> GetAllTeachers();
        public List<Lesson> GetAllLessonsSubstitution();
        public Lesson AddTeacherLesson(Lesson lesson);
        public Lesson EditTeacherLesson(Lesson lesson);
        public void DeleteLesson(Lesson lesson);
        public IEnumerable GetLessonsByClassId(int id);
        public IEnumerable GetLessonsByCabinetId(int id);
        public IEnumerable GetLessonsBySubjectId(int id);
        public IEnumerable GetLessonsByTeacherId(int id);
        public IEnumerable GetLessonsByClassIdReplaced(int id);
        public IEnumerable GetLessonsByCabinetIdReplaced(int id);
        public IEnumerable GetLessonsBySubjectIdReplaced(int id);
        public IEnumerable GetLessonsByTeacherIdReplaced(int id);
    }
}