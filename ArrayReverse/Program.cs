using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:\n");
            int[] nums = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter your number {0} : ", i + 1);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\nOutput:");
            Console.WriteLine("\nResult of the reverse Array");

            for (int i = 4; i >= 0; i--)
                Console.WriteLine("{0}", nums[i]);
            Console.WriteLine("\nEnter any key to quit!");
            Console.ReadLine();
        }
    }
}
