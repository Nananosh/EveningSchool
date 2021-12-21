using System.Collections;
using System.Collections.Generic;
using EveningSchool.Models;

namespace EveningSchool.Business.Interfaces
{
    public interface ITeacherService
    {
        public List<Teacher> GetAllTeachers();
    }
}