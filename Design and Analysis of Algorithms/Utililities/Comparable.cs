using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Utililities
{
    public static class Comparable
    {
        /// <summary>
        ///*************************************************************************
        ///  Helper sorting functions.
        ///    **************************************************************************
        /// </summary>

        // is v < w ?
        public static bool less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        // is v < w ?
        public static bool less(object v, object w, IComparer comparator)
        {
            return comparator.Compare(v, w) < 0;
        }

        // exchange a[i] and a[j]
        public static void exch(object[] a, int i, int j)
        {
            object swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }

        // exchange a[i] and a[j]  (for indirect sort)
        public static void exch(int[] a, int i, int j)
        {
            int swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }

        /// <summary>
        ///*************************************************************************
        ///  Check if array is sorted - useful for debugging.
        /// **************************************************************************
        /// </summary>
        public static bool isSorted(IComparable[] a)
        {
            return isSorted(a, 0, a.Length - 1);
        }

        // is the array sorted from a[lo] to a[hi]
        public static bool isSorted(IComparable[] a, int lo, int hi)
        {
            for (int i = lo + 1; i <= hi; i++)
            {
                if (less(a[i], a[i - 1]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isSorted(object[] a, IComparer comparator)
        {
            return isSorted(a, 0, a.Length - 1, comparator);
        }

        // is the array sorted from a[lo] to a[hi]
        public static bool isSorted(object[] a, int lo, int hi, IComparer comparator)
        {
            for (int i = lo + 1; i <= hi; i++)
            {
                if (less(a[i], a[i - 1], comparator))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
