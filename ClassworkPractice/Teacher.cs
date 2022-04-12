using System;
using System.Collections.Generic;
using System.Text;

namespace ClassworkPractice
{
    class Teacher:Person
    {
        private int _experience;

        public static int id;
        public int Id { get; protected set; }



        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value > 0 && value <= 80)
                {
                    _experience = value;
                }
            }
        }


        public Teacher(int experience,string name,string surname,int age):base(name,surname,age)
        {
            Id = ++id;

            Experience = experience;
        }

        public void ShowTeacher()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Experience: {Experience}, Id: {Id}");
        }

       

    }
}
