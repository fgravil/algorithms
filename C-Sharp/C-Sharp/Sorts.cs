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
            int key, prev;
            for(int i = 2; i < arr.Length; i++)
            {
                key = arr[i];
                prev = i - 1;

                while(prev >= 0 && arr[prev] > key)
                {
                    arr[prev + 1] = arr[prev];
                    prev--;
                }

                arr[prev + 1] = key;
            }
            return arr;
        }
    }
}
