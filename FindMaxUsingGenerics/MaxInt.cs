using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class MaxInt
    {
       
             public int NumberMax(int first_No, int second_No, int third_No)
              {
                Console.WriteLine("Three Integer numbers are : num1 = {0} , num2 = {1} , num3 = {2} ", first_No, second_No, third_No);

                if (first_No.CompareTo(second_No) > 0 && first_No.CompareTo(third_No) > 0)
                {
                    Console.Write("Maximum integer number is: ");
                    return first_No;
                }
                else if (second_No.CompareTo(third_No) > 0 && second_No.CompareTo(first_No) > 0)
                {
                    Console.Write("Maximum Integer Number Is : ");
                    return second_No;
                }
                else if (third_No.CompareTo(first_No) > 0 && third_No.CompareTo(second_No) > 0)
                {
                    Console.Write("Maximum Integer Number Is : ");
                    return third_No;
                }
                else
                {
                    Console.WriteLine("Numbers are equal");
                }
                return 0;
            }
        }
    }

