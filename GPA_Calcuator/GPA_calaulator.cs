using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calcuator
{
    public class GPA_calaulator
    {   private List<Student> students = new List<Student>();
        private double unit = 3;
        public void setStudent(Student student)
        {
            this.students.Add(student);
        }
        public Student GetHighScore()
        {
            double height = 0;
            Student returnStudent = new Student("", 0);
            foreach (Student student in students)
            {

                if (student.Gpa() > height)
                {
                    height = student.Gpa();
                    returnStudent = student;
                
                }

            }

            return returnStudent;

        }

        public double AverageGPA()
        {
            double sum = 0;
        
        
        foreach (Student student in students)
            {
                sum += student.Gpa();

            }
            return sum / this.students.Count;
        }
        
        public Student getLowesotScore()
        {
            double low = this.GetHighScore().Gpa();
            Student returnStudent = new Student("", 0);
            foreach (Student student in students)
            {
                if ( student.Gpa() > low)
                {
                    low = student.Gpa();
                    returnStudent = student;
                }
            }
            return returnStudent;
        }  
    
        public double getGPAx()
        {
            double sum = 0;
            foreach(Student student in students)
            {
                sum += student.Gpa()*unit;

            }
            return sum/(this.students.Count * unit); 

        }
    }   

}
