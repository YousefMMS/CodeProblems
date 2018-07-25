using CodeProblems.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------//
            //------------------------------------------------------//
            // --- just uncomment the portion code block to run --- //
            //------------------------------------------------------//
            //------------------------------------------------------//


            //var res = Problems.GetOddNumsBetweenTwoInputs.oddNumbers(4, 20);

            //var arr = new int[] { 1, 2, 3, 4, 5 };
            //var res = Problems.LeftRotaionArray.leftRotateArray(arr, 5, 2);
            //Problems.LeftRotaionArray.printArray(res);

            //var string1 = "cxxde";
            //var string2 = "abxxc";
            //var res = 
            //    Problems.AnagramsStrings.NumbersRequiredToDeleteFromBothStrings(string1, string2);

            //Polygons.CheckPolygon();

            //ValidBytes.CheckIfValidBytes();

            //CustomerServiceHotline.CustomerServiceHotlineRequired();

            var rowMag = "two times three is not four";
            var rowRansom = "two times two is four";
            if (HashtableRansomNote.HashtableProblem(rowMag, rowRansom))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}