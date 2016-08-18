using Design_and_Analysis_of_Algorithms.Algorithms.Factories;
using Design_and_Analysis_of_Algorithms.Algorithms.Interfaces;
using Design_and_Analysis_of_Algorithms.Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Design and Analysis examples

            IAnalyze naive = AnalysisFactory.GetAnalysisAlg(1);
            var result = naive.Compute(7, 7);

            IAnalyze russian = AnalysisFactory.GetAnalysisAlg(2);
            var result2 = russian.Compute(14, 11);

            #endregion

            #region Sorting examples

            //examples
            //int[] arr = new int[6]{23,42,4,16,8,15};
            IComparable[] arr = new IComparable[6] { 5,2,4,6,1,3 };

            ISort insertionSort = SortFactory.GetSortingAlg(1);
            
            WriteOutArray(arr);
            
            insertionSort.Sort(arr);

            Console.WriteLine("");

            Console.WriteLine("After sort");

            WriteOutArray(arr);      

            ISort selectionSort = SortFactory.GetSortingAlg(2);
            selectionSort.Sort(arr);

            //InsertionSort s = new InsertionSort();
            //var t = s.SortNonDecreasing(arr);
         
            #endregion

            #region Search examples
            #endregion

            Console.ReadLine();

        }

        private static void WriteOutArray(IComparable[] arr)
        {
            Console.Write("Array: ");
            foreach (var v in arr)
            {
                Console.Write(v);
            }
        }
    }
}
