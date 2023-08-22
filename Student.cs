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
        private int secondName { get; set; }

        public Student(string name, int age, double finalScore)
        {
            this.name = name;
            this.age = age;
            this.finalScore = finalScore;
        }

        //public Student(string name, int age)
        //{
        //    this.name = name;
        //    this.age = age;
        //}

        public Student(string name, int age) 
            : this(name, age, 0) { }
        
        public void Hello()
        {
            Console.WriteLine("Hello from {0}", name);
            
        }

        public string GetName()
        {
            if (age > 18)
            {
                return name;
            }
            else
            {
                return "This student is too young to know his name";
            }
        }

        public void SetName(string NewName)
        {
            if (NewName != "" & NewName.Length > 1)
            {
                name = NewName;
            }
        }

        public int GetAge()
        {
            if (age >= 18)
            {
                return age;
            }
            else
            {
                return -1;
            }
        }

        public int SetAge(int NewAge)
        {
            if (age >= 18 & NewAge >0)
            {
                age = NewAge;
                return age;
            }
            else
            {
                return -1;
            }
        }

        public double GetFinalScore()
        {
            if (age >= 18)
            {
                return finalScore;
            }
            else
            {
                return -1;
            }
        }

        public double SetFinalScore(double NewFinalSore)
        {
            if (finalScore < 65)
            {
                finalScore = 65;
            }
            else if (finalScore > 100)
            {
                finalScore = 100;
            }
            else
            {
                finalScore = NewFinalSore;
            }
            return finalScore;
        }




    }
}
