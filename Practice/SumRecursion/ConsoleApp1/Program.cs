using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 50, 55 };
            Console.WriteLine(Recursion.Sum(list));

            var arr = new int[] {  50, 155151151};
            Console.WriteLine(Recursion.Sum(arr));
            var list2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Count List " + Recursion.CountList(list2));
          
        }
    }
}
