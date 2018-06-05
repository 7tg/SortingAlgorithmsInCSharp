using System;
using System.Dynamic;
using System.Collections;

namespace SortingAlgorithms
{
    public class RandomArray
    {
        public int[] array { get;  set;}

        public RandomArray(int arraySize)
        {
            array = new int[arraySize];
        }

        public void FillArrayRandom()
        {
            Random rd = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(100);
            }
        }

        public int[] Clone()
        {
            return (int[])array.Clone();
        }

        public void ShuffleArray()
        {
            Random rd = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = array[rd.Next(0, array.Length - 1)];
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+"\n");
            }
            Console.WriteLine();
        }

    }
}