using C42_G02_ADV01.Question_1;
using C42_G02_ADV01.Question_2;

namespace C42_G02_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1
            // - (1) The Bubble Sort  can be optimized by adding a [flag] that helps to determine if the array is already sorted.
            // - (2) so if no swaps are needed during a pass, the algorithm can terminate early, avoiding unnecessary iterations.

            //int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            //Console.WriteLine("un sorted array :");
            //foreach (int item in array)
            //{
            //    Console.Write(item  + " "); // 64 34 25 12 22 11 90
            //}
            //Console.WriteLine("\n");


            //OptimizeBubbleSort.optimizeBubbleSort(array);
            //Console.WriteLine("after optimize bubble sort :");
            //foreach (int item in array)
            //{
            //    Console.Write(item +  " "); // 11 12 22 25 34 64 90
            //}
            //Console.WriteLine("\n");




            #endregion


            #region Q2

            //Range<int> range = new Range<int>(1,7);
            //Console.WriteLine(range.ToString()); // Range: [1 - 7]
            //Console.WriteLine(range.isInRange(8)); // False
            //Console.WriteLine(range.isInRange(3)); // True
            //Console.WriteLine(range.Length()); // 6


            #endregion


        }
    }
}
