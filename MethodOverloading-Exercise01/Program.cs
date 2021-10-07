using System;

namespace MethodOverloading_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.2m, 34.2m));
            Console.WriteLine(Add(1, 0, false));
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool a)
        {
            if (a)
            {
                return (x + y) > 1 ? $"{x+y} dollars" : $"1 dollar";
            }
            return "I guess you didn't want to add the numbers.";
        }
    }
}
