using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public static class CountingSort
    {
        public static long Sort(int[] array)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int min, max;
            FindMinMaxValue(array, out min,out max);

            int[] countArray = new int[(max - min) + 1];

            foreach (var i in array)
            {
                countArray[array[i] - min] += 1;
            }

            int j = 0;
            for (int i = min; i < max; i++)
            {
                while (countArray[i - min] > 0)
                {
                    array[j++] = i;
                    countArray[i - min]--;
                }
            }
            
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        
        private static  void FindMinMaxValue(int[] array,out int min,out int max)
        {
            min = 0;
            max = 0;
            foreach (var i in array)
            {
                if (i < min)
                {
                    min = i;
                }

                if (i > max)
                {
                    max = i;
                }
            }
        }
    }

}
