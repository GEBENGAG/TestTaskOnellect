using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOnellect
{
    public  class CockTailSort
    {
        public static int[] Sort(int[] arrayCockTailsort)
        {
            int left = 0,
            right = arrayCockTailsort.Length - 1,
            count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (arrayCockTailsort[i] > arrayCockTailsort[i + 1])
                        Program.Swap(arrayCockTailsort, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (arrayCockTailsort[i - 1] > arrayCockTailsort[i])
                        Program.Swap(arrayCockTailsort, i - 1, i);
                }
                left++;

            }
            return arrayCockTailsort;
        }


        



    }
}
