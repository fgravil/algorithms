using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 7, 5, 3, 6, 2, 0 };
            Sorts sort = new Sorts();

            Console.Write("Initial Array: ");
            foreach (var num in arr) Console.Write("{0} ", num);

            Console.WriteLine();

            sort.InsertionSort(arr);

            Console.Write("Array After Insertion Sort: ");
            foreach (var num in arr)
            {
                Console.Write("{0} ", num);
            }

            Console.ReadLine();
        }
    }
}
