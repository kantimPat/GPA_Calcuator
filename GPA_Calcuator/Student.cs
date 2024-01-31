using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calcuator
{
    public class Student
    {
        private string StudentName;
        private double gpa;

        public Student(string name , double gpa) 
        {
           this.StudentName = name;
           this.gpa = gpa;
        
        }
        public double Gpa() { return gpa; }

    
    }
}
