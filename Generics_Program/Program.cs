using System;

namespace Generics_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Problem using Generics");
            Console.Write("Enter the first value: ");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second value: ");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third value: ");
            int Third = Convert.ToInt32(Console.ReadLine());
            Max_Integer max_Integer = new Max_Integer(First, Second, Third);
        }
    }
    public class Max_Integer
    {
        public Max_Integer(int First, int Second, int Third)
        {
            int[] Sort = { First, Second, Third };
            Console.WriteLine("\nThe maximum of the given values is " + Sort.Max());
        }
    }
}