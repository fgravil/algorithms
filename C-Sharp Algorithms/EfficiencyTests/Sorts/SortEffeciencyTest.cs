using C_Sharp.Sorts;
using System;
using System.Diagnostics;

namespace EfficiencyTests
{
    public class SortEfficiencyTest : ISortEfficiencyTest
    {
        public SortEfficiencyTest()
        {

        }

        public void CompareSorts(int[] arr, ISorter algorithm1, ISorter algorithm2)
        {
            TimeSpan algorithm1_time = TimeOperation(arr, algorithm1);
            TimeSpan algorithm2_time = TimeOperation(arr, algorithm2);

            Console.WriteLine("{0} elapsed time: {1}", algorithm1.Name, algorithm1_time);
            Console.WriteLine("{0} elapsed time: {1}", algorithm2.Name, algorithm2_time);
        }

        private TimeSpan TimeOperation(int[] arr, ISorter algorithm)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            algorithm.Sort(arr);
            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

    }
}
