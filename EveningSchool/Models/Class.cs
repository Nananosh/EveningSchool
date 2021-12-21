using System.Collections.Generic;

namespace EveningSchool.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Student> Students { get; set; }
    }
}