using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static long Sort(int[] array)
        {
            
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (var lastUnsortedIndex = array.Length-1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            {
                for (var i = 0; i < lastUnsortedIndex; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        swap(array,i,i+1);
                    }
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private static void swap(int[] array, int first, int second)
        {
            if (first == second) return;
            
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}