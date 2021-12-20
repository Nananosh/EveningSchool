namespace EveningSchool.Models
{
    public class Student
    {
        public int Id { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    }
}