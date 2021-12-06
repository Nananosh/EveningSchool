using System.Collections.Generic;

namespace EveningSchool.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Telephone { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Student> Students { get; set; }
    }
}