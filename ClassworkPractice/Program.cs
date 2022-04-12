using System;

namespace ClassworkPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //int experience;

            //do
            //{
            //    Console.WriteLine("Enter age please");

            //    age = Convert.ToInt32(Console.ReadLine());


            //} while (age<0);

            //Student student = new Student("ILKIN", "YUSUBOV", age);

            //student.ShowStudents();

            //do
            //{
            //    Console.WriteLine("Enter Teacher Experience please");

            //    experience = Convert.ToInt32(Console.ReadLine());

            //} while (experience<1 || experience>80);


            //Teacher teacher = new Teacher(experience, "Gulnar", "Agazade", 40);

            //teacher.ShowTeacher();


            Student student1 = new Student("Fatime","Hesenzade",21);

            Student student2 = new Student("Resid","Memmedov",20);
            
            Group group1 = new Group();

            group1.AddStudent(student1);
            group1.AddStudent(student2);

          
            foreach (Student student in group1.Students)
            {
                Console.WriteLine(student.Name + " " + student.Surname + " " + student.Age); 
            }


           
        }
    }
}
