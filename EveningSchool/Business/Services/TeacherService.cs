using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using EveningSchool.Models;
using Microsoft.EntityFrameworkCore;

namespace EveningSchool.Business.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ApplicationContext db;

        public TeacherService(ApplicationContext context)
        {
            this.db = context;
        }

        public List<Teacher> GetAllTeachers()
        {
            var teachers = db.Teachers
                .Include(u => u.User)
                .ToList();
            return teachers;
        }
    }
}