using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Sorts
{
    public class MergeSort : ISorter
    {
        public int[] Sort(int[] arr)
        {
            int arrLength = arr.Length;

            if(arrLength < 2)
            {
                return arr;

            }
            int mid = arr.Length / 2;
            int[] leftArr = new int[mid];
            int[] rightArr = new int[arrLength - mid];

            for(int i = 0; i < mid; i++)
            {
                leftArr[i] = arr[i];
            }
            for(int i = 0; i < rightArr.Length; i++)
            {
                rightArr[i] = arr[mid + i];
            }

            Sort(leftArr);
            Sort(rightArr);
            Merge(leftArr, rightArr, arr);

            return arr;
        }

        private void Merge(int[] leftArr, int[] rightArr, int[] arr)
        {
            int leftLength = leftArr.Length;
            int rightLength = rightArr.Length;
            int i = 0, j = 0, k = 0;

            while(i < leftLength && j < rightLength)
            {
                if(leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while(i < leftLength)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            while(j < rightLength)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }
    }
}
