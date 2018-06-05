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
            RandomArray arr = new RandomArray(100);
            arr.FillArrayRandom();
            arr.PrintArray();
            Console.WriteLine("Bubble Sort Took(miliseconds):"+BubbleSort.Sort(arr.Clone()));
            Console.WriteLine("Selection Sort Took(miliseconds):"+SelectionSort.Sort(arr.Clone()));
            Console.WriteLine("Selection Sort Took(miliseconds):"+SelectionSort.Sort(arr.array));
            arr.PrintArray();

        }


    }


}
