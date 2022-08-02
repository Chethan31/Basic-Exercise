
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Passing
{
    internal class Driver
    {
        public static void Main()
        {
            ParameterTest test = new ParameterTest();
            test.Value(5);
            test.Value(10);
            Console.WriteLine(test.get());
            int a = 10;
            int b = 20;
            Console.WriteLine("Before Swap:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            test.Swap(ref a, ref b);
            Console.WriteLine("After Swap:");
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("Min & Max");

            int[] arr = new int[5];

            Console.WriteLine("Enter Array Elements:");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min, max;

            test.MinMax(arr, out min, out max);

            Console.WriteLine($"Minmum:{min}");
            Console.WriteLine($"Maximum:{max}");


        }
    }
}
