using System;
using System.Collections.Generic;

namespace PracticePlural
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<int>() { 10, 20, 30, 40, 50, 60 };
            
            var result = 0;

            foreach(var x in grades)
            {
                result += x;
            }
            Console.WriteLine(result);

















        }
    }
}
