using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbelsortprogram
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 15, 14, 23, 22, 19 };
            SortAlgo sortAlgo = new SortAlgo();

            Console.WriteLine("Before Sorting:");
            sortAlgo.displayArray(array);

            sortAlgo.bubbleSort(array);

            Console.WriteLine("After Sorting:");
            sortAlgo.displayArray(array);
        }
    }
}
    

