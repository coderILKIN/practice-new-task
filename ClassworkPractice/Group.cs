using System;
using System.Collections.Generic;
using System.Text;

namespace ClassworkPractice
{
    class Group
    {
        public int GroupNo { get; set; }

        public Student[] Students = new Student[0];


        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
    }
}
