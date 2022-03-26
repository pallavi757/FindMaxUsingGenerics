using System;

namespace FindMaxUsingGenerics
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            MaxInt maxint = new MaxInt();
            Console.WriteLine(maxint.NumberMax(20, 60, 40));
        }
    }
}
