using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Problems
{
    public class GetOddNumsBetweenTwoInputs
    {
        public static int[] oddNumbers(int l, int r)
        {
            var list = new List<int>();

            var first = l;
            var last = r;

            if (!isOdd(first))
                first += 1;

            while (first <= last)
            {
                list.Add(first);

                first += 2;
            }

            return list.ToArray();
        }

        static bool isOdd(int num)
        {
            return (num % 2) == 1;
        }
    }
}
