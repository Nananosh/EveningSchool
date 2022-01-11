using System.Collections.Generic;
using Newtonsoft.Json;

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
        public string Category { get; set; }
        [JsonIgnore]
        public List<Lesson> Lessons { get; set; }
    }
}