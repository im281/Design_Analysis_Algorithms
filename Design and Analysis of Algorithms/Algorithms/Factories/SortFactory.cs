using Design_and_Analysis_of_Algorithms.Algorithms.Interfaces;
using Design_and_Analysis_of_Algorithms.Algorithms.Search;
using Design_and_Analysis_of_Algorithms.Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Algorithms.Factories
{
    public static class SortFactory
    {
        /// <summary>
        /// 1 = Insertion Sort, 2 = Selection Sort,3 = Merge Sort, 4 = Quick Sort
        /// </summary>
        /// <param name="alg"></param>
        /// <returns></returns>
        public static ISort GetSortingAlg(int alg)
        {
            switch (alg)
            {
                case 1:
                    return new InsertionSort();
                    break;
                case 2:
                    return new SelectionSort();
                    break;
                case 3:
                    return new MergeSort();
                case 4:
                    return new QuickSort();
                default:
                    return null;
                    break;
            }
        }      
    }
}
