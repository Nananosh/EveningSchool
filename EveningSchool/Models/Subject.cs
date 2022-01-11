using System.Collections.Generic;
using Newtonsoft.Json;

namespace EveningSchool.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        [JsonIgnore]
        public List<Lesson> Lessons { get; set; }
    }
}