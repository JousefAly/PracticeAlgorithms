﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 50, 55 };
            Console.WriteLine(SumFunction.Sum(list));

            var arr = new int[] {  50, 155151151};
            Console.WriteLine(SumFunction.Sum(arr));
        }
    }
}
