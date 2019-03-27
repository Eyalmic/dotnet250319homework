using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = new int[10];
            int smallerThan = 0;
            int greaterThan = 0;
            int equalTo = 0;
            int inputCount = 0;
            //get 10 input values to array
            while (inputCount < 10)
            {
                inputNumbers[inputCount] = Convert.ToInt32(Console.ReadLine());
                inputCount++;
            }
            //check value by 15
            for (int i = 0; i < 10; i++)
            {
                if (inputNumbers[i] < 15)
                {
                    smallerThan++;
                }
                else if (inputNumbers[i] > 15)
                {
                    greaterThan++;
                }
                else
                {
                    equalTo++;
                }

            }
            //print answer
            Console.WriteLine($"Smaller than 15: {smallerThan}");
            Console.WriteLine($"Greater than 15: {greaterThan}");
            Console.WriteLine($"Equal to 15: {equalTo}");
        }
    }
}
