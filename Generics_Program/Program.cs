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
            Console.WriteLine("3 String");
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
                    Maximum<int> maximum_int = new Maximum<int>(First_Int, Second_Int, Third_Int);
                    break;
                case 2:
                    Console.Write("Enter the first value: ");
                    float First_Flo = (float)Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second value: ");
                    float Second_Flo = (float)Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the third value: ");
                    float Third_Flo = (float)Convert.ToDouble(Console.ReadLine());
                    Maximum<float> maximum_flo = new Maximum<float>(First_Flo, Second_Flo, Third_Flo);
                    break;
                case 3:
                    Console.Write("Enter the first value: ");
                    string First_Str = Console.ReadLine();
                    Console.Write("Enter the second value: ");
                    string Second_Str = Console.ReadLine();
                    Console.Write("Enter the third value: ");
                    string Third_Str = Console.ReadLine();
                    Maximum<string> maximum_str = new Maximum<string>(First_Str, Second_Str, Third_Str);
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
    public class Maximum<T>
    {
        public Maximum(T First, T Second, T Third)
        {
            T[] Sort = new T[] { First, Second, Third };
            Console.WriteLine("\nThe maximum of the given values is " + Sort.Max());
        }
    }
}