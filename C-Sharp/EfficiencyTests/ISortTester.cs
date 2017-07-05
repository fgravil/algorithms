using C_Sharp.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfficiencyTests
{
    interface ISortTester
    {
        void CompareSorts(int[] arr, ISorter sort1, ISorter sort2);
    }
}
