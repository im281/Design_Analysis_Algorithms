using Design_and_Analysis_of_Algorithms.Algorithms.Interfaces;
using Design_and_Analysis_of_Algorithms.Utililities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Algorithms.Sorting
{
    public class SelectionSort : ISort
    {
        public void Sort(IComparable[] A)
        {
            var n = A.Length;

            for (int j = 0; j < n - 1; j++)
            {
                var smallest = j;

                for (int i = j + 1; i < n; i++)
                {
                    if (Comparable.less(A[i],A[smallest]))//A[i] < A[smallest])
                    {
                        smallest = i;

                    }
                }
                //swap
                Comparable.exch(A, j, smallest);
            }
        }
        public object[] Sort(object[] a)
        {
            throw new NotImplementedException();
        }
    }
}
