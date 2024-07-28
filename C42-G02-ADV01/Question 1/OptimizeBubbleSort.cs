using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV01.Question_1
{
    internal class OptimizeBubbleSort
    {

        public static void optimizeBubbleSort(int[] array)
        {
            bool flag;
            for(int i =0; i< array.Length - 1; i ++)
            {
                flag = false;
                for (int j = 0; j < array.Length - i - 1; j++ )
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                        flag = true;
                    }
                }
                if(!flag)
                {
                    break;
                }
            }

        }





    }
}
