using Design_and_Analysis_of_Algorithms.Algorithms.Interfaces;
using Design_and_Analysis_of_Algorithms.Utililities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Algorithms.Sorting
{
    public class InsertionSort :ISort
    {
        public void Sort(IComparable[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (Comparable.less(a[j], a[min]))
                    {
                        min = j;
                    }
                }
                Comparable.exch(a, i, min);
                Debug.Assert(Comparable.isSorted(a, 0, i));
            }
            Debug.Assert(Comparable.isSorted(a));
        }


        //public void Sort(IComparable[] A)
        //{
        //    int key;
            
        //    for(int j = 1; j <A.Length;j++)
        //    {
        //        key = (int)A[j];
        //        int i = j - 1;
        //        while(i > -1 && (int)A[i] > key)
        //        {
        //            //swap the next element 
        //            //with current element
        //            A[i + 1] = A[i];
        //            i = i - 1;
        //        }
        //        //assign the previous 
        //        //element with the key
        //        A[i + 1] = key;
        //   }
        //}
        //results of each iteration
        //[5,2,4,6,1,3]
        //[5,5,4,6,1,3]
        //[2,5,4,6,1,3]
        //[2,5,5,6,1,3]
        //[2,4,5,6,1,3]
        //[2,4,5,6,6,3]
        //[2,4,5,5,6,3]
        //[2,4,4,5,6,3]
        //[2,2,4,5,6,3]
        //[1,2,4,5,6,3]
        //[1,2,4,5,6,6]
        //[1,2,4,5,5,6]
        //[1,2,4,4,5,6]
        //[1,2,3,4,5,6]

        public static int LoopInvariantMax(int n, int[] a)
        {
            int m = a[0];
            // m equals the maximum value in a[0...0]
            int i = 1;
            while (i != n)
            {
                // m equals the maximum value in a[0...i-1]
                if (m < a[i])
                    m = a[i];
                // m equals the maximum value in a[0...i]
                ++i;

                // m equals the maximum value in a[0...i-1]
            }
            // m equals the maximum value in a[0...i-1], and i==n
            return m;
        }
        public object[] Sort(object[] a)
        {
            throw new NotImplementedException();
        }
        public IComparable[] SortNonDecreasing(IComparable[] A)
        {
            int key;

            for (int j = 1; j < A.Length; j++)
            {
                key = (int)A[j];
                int i = j - 1;   //the sign here is reveresed
                while (i > -1 && (int)A[i] < key)
                {
                    //swap the next element 
                    //with current element
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                //assign the previous 
                //element with the key
                A[i + 1] = key;
            }

            return A;
        }
    }
        
}
