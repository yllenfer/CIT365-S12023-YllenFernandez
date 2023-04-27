using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = str1;
            str1 += "World";

            System.Console.WriteLine(str2);
        }
    }
}
