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
            return View();
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

        public IActionResult AddClass()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddClass(ClassViewModel model)
        {
            adminService.AddClass(mapper.Map<Class>(model));
            return RedirectToAction();
        }

        public IActionResult AddSubject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSubject(SubjectViewModel model)
        {
            adminService.AddSubject(mapper.Map<Subject>(model));
            return RedirectToAction();
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
    }
}