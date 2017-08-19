using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Problems
{
    public class Polygons
    {
        public static void CheckPolygon()
        {
            var squares = 0;
            var rectangles = 0;
            var others = 0;

            var input = Console.ReadLine();

            while (input != "")
            {
                string[] rowPolygon = input.Split(' ');
                int[] polygon = ConvertToIntArray(rowPolygon);

                if (!IsValidInput(polygon))
                    others++;

                else if (IsSquare(polygon))
                    squares++;

                else if (IsRectangles(polygon))
                    rectangles++;

                else others++;

                input = Console.ReadLine();
            }

            Console.WriteLine($"{squares} {rectangles} {others}");
        }

        public static bool IsSquare(int[] polygon)
        {
            if (AllEdgesEqualed(polygon))
                return true;
            return false;
        }

        internal static bool IsRectangles(int[] polygon)
        {
            if (TopAndBottomEqualed(polygon) && LeftAndRightEqualed(polygon))
                return true;

            return false;
        }

        public static bool AllEdgesEqualed(int[] polygon)
        {
            if (polygon[0] == polygon[1] && polygon[1] == polygon[2] && polygon[2] == polygon[3])
                return true;

            return false;
        }

        public static bool TopAndBottomEqualed(int[] polygon)
        {
            if (polygon[0] == polygon[2])
                return true;

            return false;
        }

        public static bool LeftAndRightEqualed(int[] polygon)
        {
            if (polygon[1] == polygon[3])
                return true;

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

        internal static bool IsValidInput(int[] polygon)
        {
            for (var i = 0; i < polygon.Length; i++)
            {
                if (polygon[i] < 0)
                    return false;
            }
            return true;
        }
    }
}
