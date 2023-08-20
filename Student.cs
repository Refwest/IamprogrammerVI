using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamprogrammerVI
{
    //// !Creating class
    //internal class Student
    //{
    //    public string Name;
    //    public int Age;
    //    public double FinalScore;

    //    public void Hello()
    //    {
    //        Console.WriteLine("Hello from {0}", Name);
    //    }
    //}

    //// !Constructors
    internal class Student
    {
        private string name;
        private int age;
        private double finalScore;

        public Student(string name, int age, double finalScore)
            {
            this.name = name;
            this.age = age;
            this.finalScore = finalScore;
            }

        public void Hello()
        {
            Console.WriteLine("Hello from {0}", name);
            
        }
    }
}
