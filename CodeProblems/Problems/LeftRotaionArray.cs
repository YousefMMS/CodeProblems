using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Problems
{
    class LeftRotaionArray
    {
        public static int[] leftRotateArray(int[] arr, int numberOfItems, int howMuch)
        {
            var rotatedArray = new int[arr.Length];
            var tempArray = new int[howMuch];

            var i = 0;
            for (; i < howMuch; i++)
            {
                tempArray[i] = arr[i];
            }

            var j = 0;
            for (; j < arr.Length - howMuch; j++, i++)
            {
                rotatedArray[j] = arr[i];
            }

            for (i = 0; i < tempArray.Length; j++, i++)
            {
                rotatedArray[j] = arr[i];
            }

            return rotatedArray;
        }

        public static void printArray(int[] arr)
        {
            for(var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
