using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArray
{
    class Program
    {
        static int[] GenerateRandomArray(int numberofItem, int largestValue)
        {
            Random generator = new Random();
            int[] result = new int[numberofItem];
            for (int i = 0; i < numberofItem; i++)
            {
                result[i] = generator.Next(largestValue);
            }
            return result;
        }
        static void Main(string[] args)
        {
            DisplayIntArray(new int[] { 21, 22, 23, 24, 25, 26 });
            Console.WriteLine("\nCreate a dianamic array");
            DisplayIntArray(GenerateRandomArray(11, 11));
            Console.WriteLine("\nOut dianamic array find Odd Even Number");
            DisplayIntArray(CountOddEven(GenerateRandomArray(11, 11)));
           
        }
        static void DisplayIntArray(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write($"{item,11:c}");
            }

        }
        static int[] CountOddEven(int[] array)
        {
            int[] result = new int[2];
            foreach (var item in array)
            {
                result[item % 2]++;
            }
            return result;
        }
       
    }
}
