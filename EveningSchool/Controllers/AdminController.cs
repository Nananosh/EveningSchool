using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using EveningSchool.Models;
using EveningSchool.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationContext db;
        private readonly IMapper mapper;
        private readonly IAdminService adminService;

        public AdminController(ApplicationContext db, IMapper mapper, IAdminService adminService)
        {
            this.db = db;
            this.mapper = mapper;
            this.adminService = adminService;
        }

        public IActionResult AdminPanel()
        {
            var code = adminService.GetRegisterCode();
            return View(code);
        }

        public IActionResult AdminTeacher()
        {
            return View();
        }

        public IActionResult AdminCabinet()
        {
            return View();
        }

        public IActionResult AdminClass()
        {
            return View();
        }

        public IActionResult AdminStudent()
        {
            return View();
        }

        public IActionResult AdminSubject()
        {
            return View();
        }

        public IActionResult AdminArticle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddClass(ClassViewModel model)
        {
            var cClass = adminService.AddClass(mapper.Map<Class>(model));
            return Json(mapper.Map<ClassViewModel>(cClass));
        }

        [HttpPost]
        public IActionResult AddSubject(SubjectViewModel model)
        {
            var subject = adminService.AddSubject(mapper.Map<Subject>(model));
            return Json(mapper.Map<SubjectViewModel>(subject));
        }

        [HttpPost]
        public IActionResult AddCabinet(CabinetViewModel model)
        {
            var cabinet = adminService.AddCabinet(mapper.Map<Cabinet>(model));
            return Json(mapper.Map<CabinetViewModel>(cabinet));
        }

        [HttpPost]
        public IActionResult AddStudent(StudentViewModel model)
        {
            var student = adminService.AddStudent(mapper.Map<Student>(model));
            return Json(mapper.Map<StudentViewModel>(student));
        }

        [HttpPost]
        public IActionResult EditStudent(StudentViewModel model)
        {
            var student = adminService.EditStudent(mapper.Map<Student>(model));
            return Json(mapper.Map<StudentViewModel>(student));
        }

        [HttpPost]
        public IActionResult EditTeacher(TeacherViewModel model)
        {
            var teacher = adminService.EditTeacher(mapper.Map<Teacher>(model));
            return Json(mapper.Map<TeacherViewModel>(teacher));
        }

        [HttpPost]
        public IActionResult EditCabinet(CabinetViewModel model)
        {
            var cabinet = adminService.EditCabinet(mapper.Map<Cabinet>(model));
            return Json(mapper.Map<CabinetViewModel>(cabinet));
        }

        [HttpPost]
        public IActionResult EditClass(ClassViewModel model)
        {
            var cClass = adminService.EditClass(mapper.Map<Class>(model));
            return Json(mapper.Map<ClassViewModel>(cClass));
        }

        [HttpPost]
        public IActionResult EditSubject(SubjectViewModel model)
        {
            var subject = adminService.EditSubject(mapper.Map<Subject>(model));

            return Json(mapper.Map<SubjectViewModel>(subject));
        }

        [HttpDelete]
        public void DeleteStudent(StudentViewModel model)
        {
            adminService.DeleteStudent(mapper.Map<Student>(model));
        }

        [HttpDelete]
        public void DeleteClass(ClassViewModel model)
        {
            adminService.DeleteClass(mapper.Map<Class>(model));
        }

        [HttpDelete]
        public void DeleteSubject(SubjectViewModel model)
        {
            adminService.DeleteSubject(mapper.Map<Subject>(model));
        }
        
        [HttpDelete]
        public void DeleteCabinet(CabinetViewModel model)
        {
            adminService.DeleteCabinet(mapper.Map<Cabinet>(model));
        }
        
        [HttpDelete]
        public void DeleteTeacher(TeacherViewModel model)
        {
            adminService.DeleteTeacher(mapper.Map<Teacher>(model));
        }

        [HttpPost]
        public IActionResult EditRegisterCode(RegisterCode model)
        {
            var registerCode = adminService.EditRegisterCode(model);
            return RedirectToAction("AdminPanel","Admin");
        }
    }
}