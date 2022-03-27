using System;

namespace FindMaxUsingGenerics
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            MaxInt maxint = new MaxInt();
            Console.WriteLine(maxint.NumberMax(20, 60, 40));

            MaxFloat maxfloat = new MaxFloat();
            Console.WriteLine(maxfloat.NumberMax(10.10f,11.10f,12.12f));

            MaxString maxstring = new MaxString();
            Console.Write(maxstring.Maxstring("Apple","Jackfruit","Orange"));
           
      }
    }
}
