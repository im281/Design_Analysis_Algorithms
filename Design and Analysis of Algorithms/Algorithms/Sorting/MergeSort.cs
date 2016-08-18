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
    public class MergeSort : ISort
    {
        public void Sort(IComparable[] a)
        {
            Run(a);
        }
        public void Run(IComparable[] a)
        {
            IComparable[] aux = new IComparable[a.Length];
            RunMergeSort(a, aux, 0, a.Length - 1);
            Debug.Assert(Comparable.isSorted(a));
        }
        
        public object[] Sort(object[] a)
        {
            throw new NotImplementedException();
        }
        
        // stably merge a[lo .. mid] with a[mid+1 ..hi] using aux[lo .. hi]
        private static void Merge(IComparable[] a, IComparable[] aux, int lo, int mid, int hi)
        {
            // precondition: a[lo .. mid] and a[mid+1 .. hi] are sorted subarrays
            Debug.Assert(Comparable.isSorted(a, lo, mid));
            Debug.Assert(Comparable.isSorted(a, mid + 1, hi));

            // copy to aux[]
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            // merge back to a[]
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                {
                    a[k] = aux[j++];
                }
                else if (j > hi)
                {
                    a[k] = aux[i++];
                }
                else if (Comparable.less(aux[j], aux[i]))
                {
                    a[k] = aux[j++];
                }
                else
                {
                    a[k] = aux[i++];
                }
            }

            // postcondition: a[lo .. hi] is sorted
            Debug.Assert(Comparable.isSorted(a, lo, hi));
        }
        // mergesort a[lo..hi] using auxiliary array aux[lo..hi]
        private static void RunMergeSort(IComparable[] a, IComparable[] aux, int lo, int hi)
        {
            if (hi <= lo)
            {
                return;
            }
            else
            {
                int mid = lo + (hi - lo) / 2;
                RunMergeSort(a, aux, lo, mid);
                RunMergeSort(a, aux, mid + 1, hi);
                Merge(a, aux, lo, mid, hi);
            }
        }


    }
}
