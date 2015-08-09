using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullingStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a student object.
            Student s1 = new Student();
            s1.Name = "Jenny";

            Student s2 = new Student();
            s2.Name = s1.Name;

            //Changing the name in the s1 object does 
            // not change the object itself because the toUpper() 
            // returns a new string without modifying the original

            s2.Name = s1.Name.ToUpper();
            Console.WriteLine("s1 - " + s1.Name + ", s2 - " + s2.Name);
            Console.Read();



        }
    }

    //Student -- You just need a class with a string in it
    class Student
    {
        public String Name;
    }


}
