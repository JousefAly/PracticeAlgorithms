using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class SumFunction
    {
        public static int Sum(List<int> list)
        {
            if (list.Count == 0)
            {
                return 0;
            }
            else
            {
                var number = list[0];
                list.RemoveAt(0);
                return number + Sum(list);
            }
        }
        public static int Sum(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            else
            {
                var left = arr[0];
                arr = RemoveItem(arr, left);
                return left + Sum(arr);
            }

        }
        private static int[] RemoveItem(int[] arr, int itemToRemove)
        {

            return arr.Where(e => e != itemToRemove).ToArray();
        }
    }
}
