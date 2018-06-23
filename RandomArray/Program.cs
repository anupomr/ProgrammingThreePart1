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
            DisplayIntArray(new int[] { 21, 22, 23, 24, 25, 26, 27 });
        }
        static void DisplayIntArray(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write($"{item,16:c}\n");
            }

        }
    }
}
