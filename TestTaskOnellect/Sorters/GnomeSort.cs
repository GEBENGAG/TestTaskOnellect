using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOnellect
{
    internal class GnomeSort
    {
        public static int[] Sort(int[] arrayGnomeSort)
        {
            int i = 1;
            int j = 2;

            while (i < arrayGnomeSort.Length)
            {
                if (arrayGnomeSort[i-1] > arrayGnomeSort[i])
                {
                    i= j;
                    j += 1;
                }
                else
                {
                    Program.Swap(arrayGnomeSort,i-1,i);
                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
            } 
            return arrayGnomeSort;
        }

    }
}
