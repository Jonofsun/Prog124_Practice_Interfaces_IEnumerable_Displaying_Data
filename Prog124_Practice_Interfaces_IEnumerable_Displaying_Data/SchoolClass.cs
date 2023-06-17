using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Practice_Interfaces_IEnumerable_Displaying_Data
{
    public class SchoolClass
    {
        public string ClassName { get; set; }
        public List<Student> Roster { get; set; }

        public SchoolClass(string className)
        {
            ClassName = className;
            Roster = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Roster.Add(student);
        }
    }
}
