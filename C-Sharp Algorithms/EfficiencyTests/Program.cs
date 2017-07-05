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
            int[] arr = new int[] { 1, 7, 5, 3, 6, 2, 0, 3, 1, 6, 4 ,3 ,6 ,7, 8, 2,34,67, 1, 6, 2,1 ,23 ,7,9,4,2};

            SET.CompareSorts(arr, new InsertionSort(), new InsertionSort());

            Console.ReadLine();
        }
    }
}
