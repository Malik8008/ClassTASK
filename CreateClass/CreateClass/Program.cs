using System;

namespace CreateClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Haci","Mammadov","AP204",75,true);
            //student.Name = "Haci";
            //student.Surname = "Mammadov";
            //student.Group = "AP204";
            //student.Point = 75;
            //student.Graduate = true;

            student.Fullname();
            student.Getinfo();
            student.Exam();
            


            Student student2 = new Student("Malik","Seferov","AP204",85,false);
            //student2.Name = "Malik";
            //student2.Surname = "Safarov";
            //student2.Group = "AP204";
            //student2.Point = 85;
            //student2.Graduate = false;

            student2.Fullname();
            student2.Getinfo();
            student2.Exam();
        }
    }

    class Student 
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool Graduate;

        public Student(string Name,string Surname,string Group,byte Point,bool Graduate) 
        {
           this.Name = Name;
           this.Surname = Surname;
           this.Group = Group;
           this.Point = Point;  
           this.Graduate = Graduate;               
        }

        public void Fullname() 
        {
            Console.WriteLine($"Name:{Name},Surname:{Surname}");
        }

        public void Getinfo() 
        {
            Console.WriteLine($"Name:{Name},Surname:{Surname},Group:{Group},Point:{Point},Graduate:{Graduate}");
            if (Graduate == true)
            {
                Console.WriteLine("Bu telebe mezun olmuyub");
            }
            else
            {
                Console.WriteLine("Bu telebe mezun olub");
            }               
        }
        public void Exam() 
        {
            if (Point>80)
            {
                Console.WriteLine("Telebe imtahana gire biler");
            }
            else
            {
                Console.WriteLine("Telebe imtahana gire bilmez");
            }
        }
    }
}
