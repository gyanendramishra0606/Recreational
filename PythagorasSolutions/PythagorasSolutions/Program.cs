using System;

namespace PythagorasSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = 1;
            int to = 50;
            FindPythagorasSolutions(from, to);
        }

        private static void FindPythagorasSolutions(int from, int to)
        {
            for(int i = from; i <= to; ++i)
            {
                for (int j = from; j <= to; ++j)
                {
                    //check if c^2 = a^2 + b^2
                    int cSquare = i * i + j * j;

                    for (int k = from; k <= to; ++k)
                    {
                        if (cSquare == k * k)
                        {
                            Console.WriteLine("Solution is {0}, {1}, {2}", i, j, k);
                            break;
                        }
                    }
                }
            }
        }
    }
}
