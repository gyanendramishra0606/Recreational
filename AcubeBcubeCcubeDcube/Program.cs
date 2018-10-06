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
        static void Main(string[] args)
        {
            for(int a = 1; a <= UpperBound; a++)
                for(int b = 1; b <= UpperBound; b++)
                    for(int c = 1; c <= UpperBound; c++)
                    for (int d = 1; d <= UpperBound; d++)
                    {
                        if (!AreUnique(a, b, c, d))
                            continue;
                        if(cube(a) + cube(b) == cube(c) + cube(d))
                                Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);
                    }
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
