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
    }
}
