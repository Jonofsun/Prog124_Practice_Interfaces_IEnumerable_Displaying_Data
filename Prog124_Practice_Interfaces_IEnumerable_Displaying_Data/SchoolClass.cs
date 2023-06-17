using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Practice_Interfaces_IEnumerable_Displaying_Data
{
    public class SchoolClass : IEnumerable<Student>
    {
        public string ClassName { get; set; }
        private List<Student> roster;

        public SchoolClass(string className)
        {
            ClassName = className;
            roster = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            roster.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return roster.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
