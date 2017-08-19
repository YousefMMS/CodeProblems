using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Problems
{
    public class CustomerServiceHotline
    {
        // get no of additional required agents collisions problem
        // get no. of collisions
        public static void CustomerServiceHotlineRequired()
        {
            var noOfCurrentAgents = Int32.Parse(Console.ReadLine());

            var noOfRecords = Int32.Parse(Console.ReadLine());

            // true if start, false if end
            var records = new List<Tuple<int, bool>>();

            var collisions = 0;
            var maxCollisions = 0;

            for (var i = 0; i < noOfRecords; i++)
            {
                string[] splitted = Console.ReadLine().Split(' ');

                records.Add(new Tuple<int, bool>(Int32.Parse(splitted[0]), true));
                records.Add(new Tuple<int, bool>(Int32.Parse(splitted[1]), false));
            }

            records = records.OrderBy(s=>s.Item1).ToList();

            for (var i = 0; i < records.Count; i++)
            {
                if (records[i].Item2)
                {
                    collisions++;

                    if (collisions > maxCollisions)
                        maxCollisions = collisions;
                }

                else collisions--;
            }

            var additionalAgents = maxCollisions - noOfCurrentAgents;
            Console.WriteLine(additionalAgents >= 0 ? additionalAgents : 0);
        }
    }
}
