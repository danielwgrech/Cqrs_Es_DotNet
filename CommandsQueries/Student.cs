using System.Collections.Generic;

namespace CommandsQueries
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Grade> Grades { get; set; }
    }
}