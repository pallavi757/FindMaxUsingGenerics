using System;

namespace FindMaxUsingGenerics
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 20, 60, 40,77,777,60 };
            float[] floatArray = { 10.10f, 11.10f, 12.12f,44.57f,123.56f,43.78f };
            string[] stringArray = { "Apple","Jackfruit","Orange","Peach","Mango" };
			Console.Write("Select Your Choice: ");			
			int ch = int.Parse(Console.ReadLine());

			switch (ch)
			{
				case 1:									
					MaxGeneric<int> intValue = new MaxGeneric<int>(intArray);
					intValue.printMax();
				   // Console.WriteLine(intValue.testMaximum());						
					break;				
				case 2:
					MaxGeneric<float> floatValue = new MaxGeneric<float>(floatArray);
					floatValue.printMax();
				   // Console.WriteLine(floatValue.testMaximum());
					break;
				case 3:
					MaxGeneric<string> strValue = new MaxGeneric<string>(stringArray);
					strValue.printMax();	
					//Console.WriteLine(strValue.testMaximum());
					break;				
				default:
					Console.WriteLine("Enter Choice Between 1 And 3");
					break;
			}
		}
    }
}
