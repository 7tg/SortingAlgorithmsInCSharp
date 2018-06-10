using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public static class RadixSort
    {
        public static long Sort(int[] array)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int min, max;
            FindMinMaxValue( array, out min, out max);
            radixSingleSort(array, 10, FindDecimalLength(max));

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private static void radixSort(int[] input, int radix, int width) {
            for (int i = 0; i < width; i++) {
                radixSingleSort(input, i, radix);
            }
        }

        private static void radixSingleSort(int[] input, int position, int radix) {

            int numItems = input.Length;
            int[] countArray = new int[radix];

            foreach (var value in input) 
            {
                countArray[getDigit(position, value, radix)]++;
            }
            // Adjust the count array
            for (int j = 1; j < radix; j++) {
                countArray[j] += countArray[j - 1];
            }

            int[] temp = new int[numItems];
            for (int tempIndex = numItems - 1; tempIndex >= 0; tempIndex--) {
                temp[--countArray[getDigit(position, input[tempIndex], radix)]] =
                    input[tempIndex];
            }

            for (int tempIndex = 0; tempIndex < numItems; tempIndex++) {
                input[tempIndex] = temp[tempIndex];
            }

        }

        private static int FindDecimalLength(int max)
        {
            int decimalLength = 0;
            int diveder = 1;

            while ((max / diveder) != 0)
            {
                decimalLength++;
                diveder *= 10;
            }

            return decimalLength;
        }

        private static int getDigit(int position, int value, int radix) {
            return value / (int) Math.Pow(radix, position) % radix;
        }

        private static  void FindMinMaxValue(int[] array,out int min,out int max)
        {
            max = 0;
            foreach (var i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            min = max;
            foreach (var i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
        }
    }


}