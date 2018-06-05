using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static long Sort(int[] array)
        {
            
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (var lastUnsortedIndex = array.Length-1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            {
                int largest = 0;
                for (int i = 0; i < lastUnsortedIndex; i++)
                {
                    if (array[i] > array[largest])
                    {
                        largest = i;
                    }
                }
                swap(array,largest,lastUnsortedIndex);
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