using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10000;
            
            RandomArray arr = new RandomArray(arraySize);
            arr.FillArrayRandom();

            Console.WriteLine("Size of the shuffled array :"+arraySize);
            Console.WriteLine("Bubble Sort Took(miliseconds):"+BubbleSort.Sort(arr.Clone()));
            Console.WriteLine("Selection Sort Took(miliseconds):"+SelectionSort.Sort(arr.Clone()));
            Console.WriteLine("Insertion Sort Took(miliseconds):"+SelectionSort.Sort(arr.Clone()));


        }


    }


}
