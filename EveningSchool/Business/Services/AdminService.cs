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

        public Class AddClass(Class cClass)
        {
            db.Classes.Add(cClass);
            db.SaveChanges();
            var addedClass = db.Classes.FirstOrDefault(x => x.Id == cClass.Id);

            return addedClass;
        }

        public Subject AddSubject(Subject subject)
        {
            db.Subjects.Add(subject);
            db.SaveChanges();
            var addedSubject = db.Subjects.FirstOrDefault(x => x.Id == subject.Id);

            return addedSubject;
        }

        public Cabinet AddCabinet(Cabinet cabinet)
        {
            db.Cabinets.Add(cabinet);
            db.SaveChanges();
            var addedCabinet = db.Cabinets.FirstOrDefault(x => x.Id == cabinet.Id);

            return addedCabinet;
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

        public Class EditClass(Class cClass)
        {
            var editClass = db.Classes.FirstOrDefault(x => x.Id == cClass.Id);
            if (editClass != null)
            {
                editClass.ClassName = cClass.ClassName;
                db.SaveChanges();
            }

            var editedClass = db.Classes.FirstOrDefault(x => x.Id == editClass.Id);

            return editedClass;
        }

        public Subject EditSubject(Subject subject)
        {
            var editSubject = db.Subjects.FirstOrDefault(x => x.Id == subject.Id);
            if (editSubject != null)
            {
                editSubject.SubjectName = subject.SubjectName;
                db.SaveChanges();
            }

            var editedSubject = db.Subjects.FirstOrDefault(x => x.Id == editSubject.Id);

            return editedSubject;
        }

        public void DeleteStudent(Student student)
        {
            var deleteStudent = db.Students.FirstOrDefault(x => x.Id == student.Id);
            if (deleteStudent != null) db.Students.Remove(deleteStudent);
            db.SaveChanges();
        }

        public void DeleteClass(Class cClass)
        {
            var deleteClass = db.Classes.FirstOrDefault(x => x.Id == cClass.Id);
            if (deleteClass != null) db.Classes.Remove(deleteClass);
            db.SaveChanges();
        }

        public void DeleteSubject(Subject subject)
        {
            var deleteSubject = db.Subjects.FirstOrDefault(x => x.Id == subject.Id);
            if (deleteSubject != null) db.Subjects.Remove(deleteSubject);
            db.SaveChanges();
        }

        public void DeleteCabinet(Cabinet cabinet)
        {
            var deleteCabinet = db.Cabinets.FirstOrDefault(x => x.Id == cabinet.Id);
            if (deleteCabinet != null) db.Cabinets.Remove(deleteCabinet);
            db.SaveChanges();
        }

        public void DeleteTeacher(Teacher teacher)
        {
            var deleteTeacher = db.Teachers.Include(u => u.User).FirstOrDefault(x => x.Id == teacher.Id);
            var deleteUser = db.Users.FirstOrDefault(x => x.Id == deleteTeacher.User.Id);
            if (deleteTeacher != null) db.Teachers.Remove(deleteTeacher);
            if (deleteUser != null) db.Users.Remove(deleteUser);
            db.SaveChanges();
        }
    }
}