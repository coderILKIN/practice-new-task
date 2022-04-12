using System;
using System.Collections.Generic;
using System.Text;

namespace ClassworkPractice
{
    class Student:Person
    {
        public static int id;

        public int Id { get; protected set; }

        public string[] Lessons;

        public Student(string name,string surname,int age):base(name,surname,age)
        {
            Id = ++id;

        }

        public void ShowStudents()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Id: {Id}");
        }

    }
}
