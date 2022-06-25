using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Alogrithms
{
    public class SelectionSort
    {
        public static int[] Sort(int[] nums)
        {
            
        }

        private int findSmallest(int[] nums)
        {
            int smallest = int.MaxValue;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < smallest)
                    smallest = nums[i];
            }
        }
    }
}
