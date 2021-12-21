using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using EveningSchool.Models;
using EveningSchool.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EveningSchool.Business.Services
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationContext db;

        public AdminService(ApplicationContext db)
        {
            this.db = db;
        }

        public void AddClass(Class cClass)
        {
            db.Classes.Add(cClass);
            db.SaveChanges();
        }

        public void AddSubject(Subject subject)
        {
            db.Subjects.Add(subject);
            db.SaveChanges();
        }

        public Cabinet AddCabinet(Cabinet cabinet)
        {
            db.Cabinets.Add(cabinet);
            db.SaveChanges();
            var addCabinet = db.Cabinets.FirstOrDefault(x => x.Id == cabinet.Id);

            return addCabinet;
        }

        public Student AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            var addedStudent = db.Students.Include(c => c.Class).FirstOrDefault(x => x.Id == student.Id);

            return addedStudent;
        }

        public Student EditStudent(Student student)
        {
            var editStudent = db.Students.Include(c => c.Class).FirstOrDefault(x => x.Id == student.Id);
            if (editStudent != null)
            {
                editStudent.ClassId = student.ClassId;
                editStudent.Name = student.Name;
                editStudent.Surname = student.Surname;
                editStudent.Lastname = student.Lastname;
                editStudent.Telephone = student.Telephone;
                editStudent.Address = student.Address;
                db.SaveChanges();
            }

            var editedStudent = db.Students.Include(c => c.Class).FirstOrDefault(s => s.Id == editStudent.Id);

            return editedStudent;
        }

        public Teacher EditTeacher(Teacher teacher)
        {
            var editTeacher = db.Teachers.FirstOrDefault(x => x.Id == teacher.Id);
            if (editTeacher != null)
            {
                editTeacher.Name = teacher.Name;
                editTeacher.Surname = teacher.Surname;
                editTeacher.Lastname = teacher.Lastname;
                editTeacher.Telephone = teacher.Telephone;
                editTeacher.Category = teacher.Category;
                db.SaveChanges();
            }

            var editedTeacher = db.Teachers.FirstOrDefault(x => x.Id == editTeacher.Id);

            return editedTeacher;
        }

        public Cabinet EditCabinet(Cabinet cabinet)
        {
            var editCabinet = db.Cabinets.FirstOrDefault(x => x.Id == cabinet.Id);
            if (editCabinet != null)
            {
                editCabinet.CabinetNumber = cabinet.CabinetNumber;
                db.SaveChanges();
            }

            var editedCabinet = db.Cabinets.FirstOrDefault(x => x.Id == editCabinet.Id);

            return editedCabinet;
        }
    }
}