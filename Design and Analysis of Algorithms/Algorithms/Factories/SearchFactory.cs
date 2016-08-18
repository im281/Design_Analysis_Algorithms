using Design_and_Analysis_of_Algorithms.Algorithms.Interfaces;
using Design_and_Analysis_of_Algorithms.Algorithms.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Algorithms.Factories
{
    public class SearchFactory
    {
        public static ISearch GetSearchAlg(int alg)
        {
            switch (alg)
            {
                case 1:
                    return new BinarySearch();
                    break;
                case 2:
                    return null;
                    break;
                case 3:
                    return null;
                default:
                    return null;
                    break;
            }
        }
    }
}
