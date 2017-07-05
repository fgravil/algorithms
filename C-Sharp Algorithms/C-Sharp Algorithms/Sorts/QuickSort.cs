namespace C_Sharp.Sorts
{
    public class QuickSort : ISorter
    {
        public int[] Sort(int[] arr)
        {
            quicksort(arr, 0, arr.Length - 1);
            return arr;
        }
         
        private void quicksort(int[] arr, int startIndex, int endIndex)
        {
            if(startIndex < endIndex)
            {
                int partitionIndex = partition(arr, startIndex, endIndex);
                quicksort(arr, startIndex, partitionIndex - 1);
                quicksort(arr, partitionIndex + 1, endIndex);
            }
             
        }

        private int partition(int[] arr, int startIndex, int endIndex)
        {
            int pivot = arr[endIndex];
            int partitionIndex = startIndex;

            for(int i = startIndex; i < endIndex; i++)
            {
                if(arr[i] <= pivot)
                {
                    swap(arr, i, partitionIndex);
                    partitionIndex++;
                }
            }
            swap(arr, partitionIndex, endIndex);
            return partitionIndex;

        }

        private void swap(int[] arr, int index1, int index2) 
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
