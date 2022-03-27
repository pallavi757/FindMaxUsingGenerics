using System;

namespace FindMaxUsingGenerics
{
	class Program
	{
		public static void Main(string[] args)
		{
			MaxGeneric<int> maxGenericInt = new MaxGeneric<int>();
			maxGenericInt.findMax(20, 60, 40);

			MaxGeneric<float> maxGenericFloat = new MaxGeneric<float>();
			maxGenericFloat.findMax(10.10f, 11.10f, 12.12f);

			MaxGeneric<string> maxGenericStr = new MaxGeneric<string>();
			maxGenericStr.findMax("Apple", "Jackfruit", "Orange");

			
		}
	}
}
