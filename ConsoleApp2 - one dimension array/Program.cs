using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2___one_dimension_array
{
    internal class Program
    {
        static void Main(string[] args)
        {// one dimension array//
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of the array");
            int i;
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The elements of the array are");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
