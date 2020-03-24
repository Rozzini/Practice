using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1.SortingAlgorithms
{
    class QuickSorting
    {
        public static void sorting(int[] data, int first, int last)
        {
            int pointer = data[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (data[i] < pointer && i <= last) ++i;
                while (data[j] > pointer && j >= first) --j;
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sorting(data, first, j);
            if (i < last) sorting(data, i, last);
        }
    }
}
