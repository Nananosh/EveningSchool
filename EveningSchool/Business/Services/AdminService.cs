using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using EveningSchool.Models;
using EveningSchool.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Business.Services
{
    public class AdminService : IAdminService
    {
        public void AddClass(ApplicationContext db, Class cClass)
        {
            db.Classes.Add(cClass);
            db.SaveChanges();
        }
        
        public void AddSubject(ApplicationContext db, Subject subject)
        {
            db.Subjects.Add(subject);
            db.SaveChanges();
        }
        
        public void AddCabinet(ApplicationContext db, Cabinet cabinet)
        {
            db.Cabinets.Add(cabinet);
            db.SaveChanges();
        }

        public IEnumerable<Teacher> GetAllTeachers(ApplicationContext db)
        {
            var teachers = db.Teachers;
            return teachers;
        }
        public IEnumerable<Class> GetAllClasses(ApplicationContext db)
        {
            var classes = db.Classes;
            return classes;
        }

        public void AddStudent(ApplicationContext db, Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }
    }
}