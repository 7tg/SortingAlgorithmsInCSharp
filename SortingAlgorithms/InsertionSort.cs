using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        public static long Sort(int[] array)
        {
            
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int firstUnsortedIndex = 1; firstUnsortedIndex < array.Length;
                firstUnsortedIndex++) {
                int newElement = array[firstUnsortedIndex];

                int i;

                for (i = firstUnsortedIndex; i > 0 && array[i - 1] > newElement; i--) {
                    array[i] = array[i - 1];
                }

                array[i] = newElement;
            }
           
            
            
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}