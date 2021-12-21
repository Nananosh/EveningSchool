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
        public void AddClass(Class cClass);
        public void AddSubject(Subject subject);
        public Cabinet AddCabinet(Cabinet cabinet);
        public Student AddStudent(Student student);
        public Student EditStudent(Student student);
        public Teacher EditTeacher(Teacher teacher);
        public Cabinet EditCabinet(Cabinet cabinet);
    }
}