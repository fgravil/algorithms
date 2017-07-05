using C_Sharp.Sorts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

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

            Console.WriteLine("Merge Sort elapsed time: {0}", algorithm1_time);
            Console.WriteLine("Quick Sort elapsed time: {0}", algorithm2_time);
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
