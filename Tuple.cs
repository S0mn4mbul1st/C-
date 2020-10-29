using System;

namespace Tupple
{
    class Program
    {
        public class @class
        {

         string name, surname;
        }

        static void constructor( (string, string, int, double) tup)
        { 
         
            System.Console.WriteLine($"name = {tup.Item1} ---> surname = {tup.Item2} ---> age = {tup.Item3} ---> salary = {tup.Item4}");
        }
        static void Main(string[] args)
        {
            int @class = 1;

            Console.WriteLine(@class);

            string name = Console.ReadLine();
            string sname = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine()); ;
            double salary = Double.Parse(Console.ReadLine()); ;

            constructor( (name, sname, age, salary) );

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int[] arrB = new int[5] { 11, 22, 33, 44, 55 };

        
            System.Array.IndexOf(arr, 3);
            System.Array.Sort(arr);
            System.Array.Reverse(arr);
            System.Array.Copy(arr, arrB, 3);
            System.Array.Clear(arrB, 0, 5);
        }
    }
}
