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
            #region Sorting examples
     
            //examples
            //int[] arr = new int[6]{23,42,4,16,8,15};
            //[] arr = new IComparable[6] { 5,2,4,6,1,3 };
            IComparable[] arr = new IComparable[16] { "M", "E", "R", "G", "E", "S" 
                ,"O","R","T","E","X","A","M","P","L","E"};

            Console.Write("Unsorted:");
            foreach (var l in arr)
            {
                Console.Write(l);
            }

            Console.WriteLine("");
            //select sorting algorithm from factory
            Console.WriteLine("Select sorting algorithm");
            Console.WriteLine("1 = Insertion");
            Console.WriteLine("2 = Selection");
            Console.WriteLine("3 = Merge");
            Console.WriteLine("4 = Quick");
            var alg = Convert.ToInt32(Console.ReadLine());
            ISort sort = SortFactory.GetSortingAlg(alg);
            sort.Sort(arr);

            Console.WriteLine("");
            Console.Write("Sorted: ");
            foreach (var l in arr)
            {
                Console.Write(l);
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue:");
            Console.ReadLine();

         
            #endregion

            #region Search examples
            #endregion

        }
    }
}
