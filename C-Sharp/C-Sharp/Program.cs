using C_Sharp.Sorts;
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
<<<<<<< HEAD
            int[] arr = new int[] { 1, 7, 5, 3, 6, 2, 0 };
            Sorts sort = new Sorts();
=======
            int[] arr = new int[] { 1 };
            InsertionSort insertionSort = new InsertionSort();
            MergeSort mergeSort = new MergeSort();
            QuickSort quickSort = new QuickSort();
>>>>>>> 21cb3d1e9ad11664695fe9553072deefb9779df8

            Console.Write("Initial Array: ");
            foreach (var num in arr) Console.Write("{0} ", num);

            Console.WriteLine();

<<<<<<< HEAD
            sort.InsertionSort(arr);

            Console.Write("Array After Insertion Sort: ");
=======
            arr = quickSort.Sort(arr);
            Console.Write("Array After Quick Sort: ");
>>>>>>> 21cb3d1e9ad11664695fe9553072deefb9779df8
            foreach (var num in arr)
            {
                Console.Write("{0} ", num);
            }

            Console.ReadLine();
        }
    }
}
