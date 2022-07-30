using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class SumFunction
    {
        public static int Sum(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            else
            {
                return arr[0] + Sum(arr);
            }
        }
    }
}
