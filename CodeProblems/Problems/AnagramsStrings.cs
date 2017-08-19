using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Problems
{
    public class AnagramsStrings
    {
        public static int NumbersRequiredToDeleteFromBothStrings(string first, string second)
        {
            for (var i = 0; i < first.Length; i++)
            {
                var c = first[i];
                int index = second.IndexOf(c);
                if (index >= 0)
                {
                    second = second.Remove(index, 1);
                    first = first.Remove(i, 1);
                    i--;
                }
            }

            return first.Length + second.Length;
        }
    }
}
