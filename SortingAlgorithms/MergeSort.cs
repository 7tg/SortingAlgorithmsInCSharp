using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static long Sort(int[] array)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            SortMerge(array,0,array.Length);
            
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static void SortMerge(int[] input, int start, int end)
        {
            if (end - start < 2) return;

            int mid = (start + end) / 2;
            
            SortMerge(input,start,mid);
            SortMerge(input,mid,end);
            Merge(input, start, mid, end);

        }

        public static void Merge(int[] input, int start, int mid, int end) {

            if (input[mid - 1] <= input[mid]) {
                return;
            }

            int i = start;
            int j = mid;
            int tempIndex = 0;

            int[] temp = new int[end - start];
            while (i < mid && j < end) {
                temp[tempIndex++] = input[i] <= input[j] ? input[i++] : input[j++];
            }
            Array.Copy(input, i, input, start + tempIndex, mid - i);
            Array.Copy(temp, 0, input, start, tempIndex);

            }
    }
}