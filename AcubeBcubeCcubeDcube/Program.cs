using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcubeBcubeCcubeDcube
{
    class Program
    {
        private const int UpperBound = 15;
        private static List<Tuple<int, int, int, int>> _listSolution = new List<Tuple<int, int, int, int>>();
        static void Main(string[] args)
        {
            try
            {
                for(int a = 1; a <= UpperBound; a++)
                    for(int b = 1; b <= UpperBound; b++)
                        for(int c = 1; c <= UpperBound; c++)
                        for (int d = 1; d <= UpperBound; d++)
                        {
                            if (!AreUnique(a, b, c, d))
                                continue;
                            if (cube(a) + cube(b) == cube(c) + cube(d))
                            {
                                if (IsSolutionAlreadyFound(a, b, c, d))
                                    continue;


                                //Add the solution to the list
                                AddSolutionToTheList(a, b, c, d);

                                Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);
                            }
                        }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static void AddSolutionToTheList(int a, int b, int c, int d)
        {
            var solution = new Tuple<int, int, int, int>(a, b, c, d);
            _listSolution.Add(solution);
        }

        private static bool IsSolutionAlreadyFound(int a, int b, int c, int d)
        {
            foreach (var tuple in _listSolution)
            {
                SortedSet<int> solutionset = new SortedSet<int>();

                solutionset.Add(tuple.Item1);
                solutionset.Add(tuple.Item2);
                solutionset.Add(tuple.Item3);
                solutionset.Add(tuple.Item4);

                if (solutionset.Contains(a)
                    && solutionset.Contains(b)
                    && solutionset.Contains(c)
                    && solutionset.Contains(d))
                {
                    //Solution already exists
                    return true;

                }

            }

            return false;
        }

        private static bool AreUnique(int a, int b, int c, int d)
        {
           if (a == b || a == c || a == d || b == c || b == d || c == d)
                return false;
        
            return true;

        }

        private static int cube(int x)
        {
            return x * x * x;
        }
    }
}
