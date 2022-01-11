using System.Collections.Generic;
using Newtonsoft.Json;

namespace EveningSchool.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        [JsonIgnore]
        public List<Lesson> Lessons { get; set; }
        [JsonIgnore]
        public List<Student> Students { get; set; }
    }
}