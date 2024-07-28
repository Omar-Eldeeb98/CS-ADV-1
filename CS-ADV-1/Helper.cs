using CS_ADV_1.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_1
{
    internal class Helper<T> where T : IComparable<T>
    {


        #region Non Generics methods

        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //-------------------------------------------------------------------------------------------------

        public static void swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }

        //-------------------------------------------------------------------------------------------------------------------

        public static void swap(ref Point x, ref Point y)
        {
            Point temp = x;
            x = y;
            y = temp;
        }

        //---------------------------------------------------------------------------------------------------------------------

        public static int search(int[] arr, int value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (value == arr[i])
                    {
                        Console.Write($"the index of {value} is: {i} ");
                        return i; // as the index of selected value.

                    }
                }
            }
            Console.WriteLine("can not find the index of selected value.");
            return -1;
        }

        //----------------------------------------------------------------------------------------------------------------



        public static void BubbleSort(int[] array)
        {
          if(array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int k = 0; k < array.Length - i - 1; k++)
                    {
                        if (array[k] > array[k + 1])
                        {
                            Helper<int>.swap(ref array[k], ref array[k + 1]);
                        }
                    }
                }
            }
        }


        //-----------------------------------------------------------------


        #endregion


        #region Generics methods

       // generic method
        public static void swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        //--------------------------------------------------------------------------------------------------

        public static int search(T[] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (value.Equals(arr[i]))
                    {
                        Console.Write($"the index of {value} is: {i} ");
                        return i; // as the index of selected value.

                    }
                }
            }
            Console.WriteLine("can not find the index of selected value.");
            return -1;
        }


        //----------------------------------------------------------------------------------------------------------


        public static void BubbleSort(T[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int k = 0; k < array.Length - i - 1; k++)
                    {
                        if (array[k].CompareTo(array[k+1]) == 1)
                        {
                          swap(ref array[k], ref array[k + 1]);
                        }
                    }
                }
            }
        }

        #endregion


    }
}
