using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1.SortingAlgorithms
{
    class MySortingMethod
    {

        public static void Sort(int[] data)
        {
            int[] arr = new int[data.Length - 1];
            int minValue = data[0];
            int maxValue = data[0];
            int loops = 0;
            int iterator = 0;
            do
            {
                for (int i = 0; i < ((data.Length - 1)/2); i++)
                {
                    if (data[i] > maxValue)
                        maxValue = data[i];
                    if (data[i] < minValue)
                        minValue = data[i];
                }
                
                arr[iterator + loops] = minValue;
                arr[arr.Length - 1-loops] = maxValue;
                loops++;

            } while (loops != (data.Length / 2));

            Console.WriteLine("\nArray after sorting: \n");
            for(int i = 0; i<arr.Length-1;i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
