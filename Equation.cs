using System;
using System.Net.Security;

namespace equationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("A:");
            a = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("B:");
            b = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("C:");
            c = Convert.ToInt32( Console.ReadLine() );

             rootFinder(a, b, c);
        }

        static void rootFinder(double a, double b, double c)
        {
            double sqrtpart = ( b * b ) - ( 4 * a * c );

            const double neg = -1.0;

            if (a == 0)
            {
                Console.WriteLine(@"\n It is a Linear equation");

                if ( b == 0 && c != 0 )

                    Console.WriteLine("No Root");

                else if (c == 0)

                    Console.WriteLine("Root is 0");

                else

                    Console.WriteLine( (neg * c ) / b);

            }
            else if (sqrtpart < 0)

                Console.WriteLine("No Root");

            else if (sqrtpart > 0)

                Console.WriteLine((Math.Sqrt(sqrtpart) - b) / (2.0 * a) +
                                                                    " and " +
                                        (neg * Math.Sqrt(sqrtpart) - b) / (2.0 * a));

            else

                Console.WriteLine((Math.Sqrt(sqrtpart) - b) / (2.0 * a));
            }
        }
    }
}
