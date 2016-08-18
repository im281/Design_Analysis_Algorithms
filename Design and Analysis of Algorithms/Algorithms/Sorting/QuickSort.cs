using Design_and_Analysis_of_Algorithms.Algorithms.Interfaces;
using Design_and_Analysis_of_Algorithms.Utililities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Algorithms.Sorting
{
    public class QuickSort: ISort
    {

        public void Sort(IComparable[] a)
        {
            Shuffle(a);
            RunQuickSort(a, 0, a.Length - 1);
            Debug.Assert(Comparable.isSorted(a));
        }

        public object[] Sort(object[] a)
        {
            throw new NotImplementedException();
        }
        // quicksort the subarray from a[lo] to a[hi]
        private static void RunQuickSort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo)
            {
                return;
            }
            int j = partition(a, lo, hi);
            RunQuickSort(a, lo, j - 1);
            RunQuickSort(a, j + 1, hi);
            Debug.Assert(Comparable.isSorted(a, lo, hi));
        }
     
        // partition the subarray a[lo..hi] so that a[lo..j-1] <= a[j] <= a[j+1..hi]
        // and return the index j.
        private static int partition(IComparable[] a, int lo, int hi)
        {
            int i = lo;
            int j = hi + 1;
            IComparable v = a[lo];
            while (true)
            {

                // find item on lo to swap
                while (Comparable.less(a[++i], v))
                {
                    if (i == hi)
                    {
                        break;
                    }
                }

                // find item on hi to swap
                while (Comparable.less(v, a[--j]))
                {
                    if (j == lo)
                    {
                        break; // redundant since a[lo] acts as sentinel
                    }
                }

                // check if pointers cross
                if (i >= j)
                {
                    break;
                }

                Comparable.exch(a, i, j);
            }

            // put partitioning item v at a[j]
            Comparable.exch(a, lo, j);

            // now, a[lo .. j-1] <= a[j] <= a[j+1 .. hi]
            return j;
        }

        public static void Shuffle<T>(T[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }


       
    }
}
