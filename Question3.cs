using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] familyAge = new int[20];
            int i = 0;
            int input = 0;
            Console.WriteLine("Please Enter age of family members by order from oldest to youngest. enter -1 to end");
            while(input >=0)
            {
                input = Convert.ToInt32(Console.ReadLine());
                familyAge[i] = input;
                i++;
            }
            Console.WriteLine($"Age of Eldest Child:{familyAge[2]}");
            Console.WriteLine($"Age of youngest Child:{familyAge[i-2]}");
            Console.WriteLine($"Number of Children in the Family: {i-3}");





        }
    }
}
