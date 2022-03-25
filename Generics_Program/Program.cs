using System;

namespace Generics_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Problem using Generics");
            Console.WriteLine("Enter the number to compare");
            Console.WriteLine("1 Integers");
            Console.WriteLine("2 Floats");
            int Control = Convert.ToInt32(Console.ReadLine());
            switch (Control)
            {
                case 1:
                    Console.Write("Enter the first value: ");
                    int First_Int = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second value: ");
                    int Second_Int = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the third value: ");
                    int Third_Int = Convert.ToInt32(Console.ReadLine());
                    Max_Integer max_Integer = new Max_Integer(First_Int, Second_Int, Third_Int);
                    break;
                case 2:
                    Console.Write("Enter the first value: ");
                    float First_Flo = (float) Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second value: ");
                    float Second_Flo = (float) Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the third value: ");
                    float Third_Flo = (float) Convert.ToDouble(Console.ReadLine());
                    Max_Float max_Float = new Max_Float(First_Flo, Second_Flo, Third_Flo);
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
            
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
    public class Max_Float
    {
        public Max_Float(float First, float Second, float Third)
        {
            float[] Sort = { First, Second, Third };
            Console.WriteLine("\nThe maximum of the given values is " + Sort.Max());
        }
    }
}