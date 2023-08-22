using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamprogrammerVI
{
    internal class Kata
    {
        public static long[] Digitize(long n)
        {
            string aString = n.ToString();
            int length = aString.Length;
            long[] array = new long[length];
            int j = length - 1;

            for (int i = 0; i < length; i++)
            {

                array[i] = int.Parse(aString.Substring(j, 1));
                j--;
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(array);
            return array;

        }
    }
}
