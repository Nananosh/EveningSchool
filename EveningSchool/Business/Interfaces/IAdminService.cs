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
        public Class AddClass(Class cClass);
        public Subject AddSubject(Subject subject);
        public Cabinet AddCabinet(Cabinet cabinet);
        public Student AddStudent(Student student);
        public Student EditStudent(Student student);
        public Teacher EditTeacher(Teacher teacher);
        public Cabinet EditCabinet(Cabinet cabinet);
        public Class EditClass(Class cClass);
        public Subject EditSubject(Subject subject);
        public void DeleteStudent(Student student);
        public void DeleteClass(Class cClass);
        public void DeleteSubject(Subject subject);
        public void DeleteCabinet(Cabinet cabinet);
        public void DeleteTeacher(Teacher teacher);
    }
}