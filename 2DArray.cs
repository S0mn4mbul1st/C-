using System;
using System.Globalization;

namespace random2Darray
{
    class Program
    {
        public static void ReverseJaggedArray(int[][] arr)
        {
            for (int i = 0; i <= (arr.GetUpperBound(0)); i++)
            {
                for (int j = 0; j <= (arr[i].GetUpperBound(0) / 2); j ++)
                {
                    int tempHolder = arr[i][j];

                    arr[i][j] = arr[i][arr[i].GetUpperBound(0) - j];
                    
                    arr[i][arr[i].GetUpperBound(0) - j] = tempHolder;
                }
            }
        }

        public static void Reverse2DArray(int[,] arr)
        {
            for (int i = 0; i <= (arr.GetUpperBound(0)); i++)
            {
                for (int j = 0; j <= (arr.GetUpperBound(1) / 2); j++)
                {
                    int tempHolder = arr[i, j];
                  
                    arr[i, j] = arr[i, arr.GetUpperBound(1) - j];
                   
                    arr[i, arr.GetUpperBound(1) - j] = tempHolder;
                }
            }
        }

        public static void Print2DArray(int[,] arr)
        {
            Console.WriteLine();

            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.WriteLine();
            }
        }

        public static void PrintJaggedArray(int[][] jagged_arr)
        {
            Console.WriteLine();

            int rowLength = jagged_arr.GetLength(0);
            int colLength = jagged_arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", jagged_arr[i][j]));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int min = 0, max = 100;

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine()); 

            int[,] arr = new int[n, m];

            Random randNum = new Random();

            for (int i = 0; i < n; i ++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = randNum.Next(min, max);
                }
            }

            Console.WriteLine("\nOrginal:");
            Print2DArray(arr);

            Reverse2DArray(arr);

            Console.WriteLine("\nReversed:");
            Print2DArray(arr);

            Console.WriteLine("\nSecond Type:");

            int[][] jaggedArr = new int[n][];


            for (int i = 0; i < n; i++)
            {

                jaggedArr[i] = new int[m];

                for (int j = 0; j < m; j++)
                {
                    jaggedArr[i][j] = randNum.Next(min, max);
                }

                Console.WriteLine();
            }

                 
            Console.WriteLine("\nOrginal:");
            PrintJaggedArray(jaggedArr);

            ReverseJaggedArray(jaggedArr);

            Console.WriteLine("\nReversed:");
            PrintJaggedArray(jaggedArr);

        }
    }
}
