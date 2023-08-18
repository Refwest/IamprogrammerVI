using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamprogrammerVI
{
    internal class Student
    {
        public string Name;
        public int Age;
        public double FinalScore;

        public void Hello()
        {
            Console.WriteLine("Hello from {0}", Name);
        }
    }
}
