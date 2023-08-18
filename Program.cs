using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace IamprogrammerVI
{
    class Program 
    {
        // 
        static void Main(string[] args)
        {

            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();

            s1.Name = "Karol";
            s1.Age = 26;
            s1.FinalScore = 95;
            s1.Hello();

            s2.Name = "Kuba";
            s2.Age = 28;
            s2.FinalScore = 90;

            s3.Name = "Artur";
            s3.Age = 26;
            s3.FinalScore = 90;

           
            Console.WriteLine(s2.Name);
            Console.WriteLine(s3.Name);


        }



    }

 
}

