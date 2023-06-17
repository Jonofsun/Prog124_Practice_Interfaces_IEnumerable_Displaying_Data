using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Practice_Interfaces_IEnumerable_Displaying_Data
{
    public class Student
    {
        public string FirstName { get; set; }

        public Student(string firstName)
        {
            FirstName = firstName;
        }

        public override string ToString()
        {
            return $"Student Name: {FirstName}";
        }
    }
}
