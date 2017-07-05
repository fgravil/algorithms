using C_Sharp.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class InsertionSort : ISorter
    {
        public int[] Sort(int[] arr)
        {
            int currValue, prevIndex;
            for(int currIndex = 1; currIndex < arr.Length; currIndex++)
            {
                currValue = arr[currIndex];
                prevIndex = currIndex - 1;

                while(prevIndex >= 0 && arr[prevIndex] > currValue)
                {
                    arr[prevIndex + 1] = arr[prevIndex];
                    prevIndex--;
                }

                arr[prevIndex + 1] = currValue;
            }

            return arr;
        }
    }
}
