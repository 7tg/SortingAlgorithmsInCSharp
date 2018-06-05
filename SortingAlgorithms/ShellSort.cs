using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public static class ShellSort
    {
        public static long Sort(int[] array)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int gap = array.Length / 2; gap > 0; gap /= 2) {

                for (int i = gap; i < array.Length; i++) {
                    int newElement = array[i];

                    int j = i;

                    while (j >= gap && array[j - gap] > newElement) {
                        array[j] = array[j - gap];
                        j -= gap;
                    }

                    array[j] = newElement;
                }
            }
            
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}