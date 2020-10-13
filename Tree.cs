using System;

namespace tree
{
    class Program
    {
        public static void PrintTree(int n)
        { 
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (j < n - i - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
    
            PrintTree(n);
        }
    }
}
