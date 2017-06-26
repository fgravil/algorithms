using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Sorts
    {
        public int[] InsertionSort(int[] arr)
        {
            int key, j;
            for(int i = 2; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;

                while(j > 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
            return arr;
        }
    }
}
