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
            //// !Creating class
            //Student s1 = new Student();
            //Student s2 = new Student();
            //Student s3 = new Student();

            //s1.Name = "Karol";
            //s1.Age = 26;
            //s1.FinalScore = 95;
            //s1.Hello();

            //s2.Name = "Kuba";
            //s2.Age = 28;
            //s2.FinalScore = 90;

            //s3.Name = "Artur";
            //s3.Age = 26;
            //s3.FinalScore = 90;


            //Console.WriteLine(s2.Name);
            //Console.WriteLine(s3.Name);


            ////// !Constructors

            //Student s1 = new Student("Karol", 26, 95);           
            //s1.Hello();
            //Console.WriteLine(s1.Name);

            //Student s3 = new Student("Artur", 26, 90);
            //s3.Hello();

            //Student s2 = new Student("Kuba", 27);
            //s2.SetName("Mi");
            //Console.WriteLine(s2.GetName());
            //s2.Hello();
            //s2.SetAge(28);
            //s2.SetFinalScore(50);
            //Console.WriteLine(s2.GetAge());
            //Console.WriteLine(s2.GetFinalScore());
            
                
            

            //Student s4 = new Student("Krzysztof", 15);
            //Console.WriteLine(s4.GetName());

            //55. Properties
            Student s1 = new Student("Karol", 26, 95);
            s1.Hello();
            s1.Name = "Bob";
            Console.WriteLine(s1.Name);

            Student s3 = new Student("Artur", 26, 90);
            s3.Hello();
            Console.WriteLine(s3.Name);

            Student s2 = new Student("Kuba", 27);
            s2.Name = "Jakub";
            Console.WriteLine(s2.Name);
            s2.Hello();
            
            Student s4 = new Student("Krzysztof", 15);
            Console.WriteLine(s4.Name);



            //////!2

            ////    long a = 9876543210;
            ////    Kata.Digitize(a);
            ////    Console.WriteLine(a);


        }



    }

 
}

