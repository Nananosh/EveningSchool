using System.Collections;
using System.Collections.Generic;
using EveningSchool.Migrations;
using EveningSchool.Models;
using EveningSchool.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Business.Interfaces
{
    public interface IAdminService
    {
        public void AddClass(ApplicationContext db, Class cClass);
        public void AddSubject(ApplicationContext db, Subject subject);
        public void AddCabinet(ApplicationContext db, Cabinet cabinet);
        public IEnumerable<Teacher> GetAllTeachers(ApplicationContext db);
        public IEnumerable<Class> GetAllClasses(ApplicationContext db);
        public void AddStudent(ApplicationContext db, Student student);
    }
}