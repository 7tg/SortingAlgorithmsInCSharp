using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public static class QuickSort
    {
        public static long Sort(int[] array)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Quick(array,0,array.Length);
            
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static void Quick(int[] input, int start, int end) {
            if (end - start < 2) {
                return;
            }

            int pivotIndex = partition(input, start, end);
            Quick(input, start, pivotIndex);
            Quick(input, pivotIndex + 1, end);
        }

        public static int partition(int[] input, int start, int end) {
            // This is using the first element as the pivot
            int pivot = input[start];
            int i = start;
            int j = end;

            while (i < j) {

                // NOTE: empty loop body
                while (i < j && input[--j] >= pivot);
                if (i < j) {
                    input[i] = input[j];
                }

                // NOTE: empty loop body
                while (i < j && input[++i] <= pivot);
                if (i < j) {
                    input[j] = input[i];
                }

            }

            input[j] = pivot;
            return j;

        }
    }
}
