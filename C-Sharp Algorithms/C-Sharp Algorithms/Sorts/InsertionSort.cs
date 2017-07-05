using System;

namespace C_Sharp.Sorts
{
    public class InsertionSort : ISorter
    {
        public string Name = "Insertion Sort";

        string ISorter.Name { get { return Name; } }

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
