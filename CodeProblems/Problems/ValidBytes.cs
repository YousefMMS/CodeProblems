using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Problems
{
    public class ValidBytes
    {
        public static void CheckIfValidBytes()
        {
            var ESCAP_CHAR = "-128";

            var rowInput = Console.ReadLine();

            string[] separatedInput = rowInput.Split(' ');
            int[] input = ConvertToIntArray(separatedInput);

            string result = String.Empty;

            for (var i = 0; i < input.Length; i++)
            {
                if (IsValidByte(input[i]))
                    result += " " + (i > 0 ? (input[i] - input[i - 1]) : input[i]);
                else result += " " + ESCAP_CHAR;
            }

            Console.WriteLine(result);
        }

        public static bool IsValidByte(int val)
        {
            if ((val >= -127) && (val <= 127))
                return true;

            else
                return false;
        }

        internal static int[] ConvertToIntArray(string[] rowPolygon)
        {
            var polygon = new int[rowPolygon.Length];
            for (var i = 0; i < polygon.Length; i++)
            {
                var val = Int32.Parse(rowPolygon[i]);
                polygon[i] = val;
            }

            return polygon;
        }
    }
}
