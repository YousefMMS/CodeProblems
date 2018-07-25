using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Problems
{
    class HashtableRansomNote
    {
        public static bool HashtableProblem(string rowMag, string rowRansom)
        {
            //var rowMag = "two times three is not four";
            //var rowRansom = "two times two is four";

            string[] mag = rowMag.Split(' ');
            string[] ransom = rowRansom.Split(' ');

            Hashtable magHashtable = new Hashtable();

            for(var i = 0; i < mag.Length; i++)
            {
                var h = magHashtable[mag[i]];
                var oldValue = h == null ? 0 : (int)h;
                magHashtable[mag[i]] = oldValue + 1;
            }

            for (var i = 0; i < ransom.Length; i++)
            {
                var h = magHashtable[ransom[i]];
                var value = h == null ? 0 : (int)h;
                if (value <= 0)
                    return false;

                else
                {
                    var oldValue = (int)magHashtable[ransom[i]];
                    magHashtable[ransom[i]] = oldValue - 1;
                }
            }

            return true;
        }

    }
}
