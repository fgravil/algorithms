using C_Sharp.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfficiencyTests
{
    class Program
    {
        static void Main(string[] args)
        {
            ISortEfficiencyTest SET = new SortEfficiencyTest();
            int[] arr = new int[] { 1, 7, 5, 3, 6, 2, 0 };

            SET.CompareSorts(arr, new MergeSort(), new QuickSort());

            Console.ReadLine();
        }
    }
}
