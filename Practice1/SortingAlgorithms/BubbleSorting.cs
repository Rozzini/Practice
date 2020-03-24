using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1.SortingAlgorithms
{
    class BubbleSorting
    {
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
       
        public static int[] BubbleSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
}
