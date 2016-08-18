using Design_and_Analysis_of_Algorithms.Algorithms.DesignAndAnalysis;
using Design_and_Analysis_of_Algorithms.Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Algorithms.Factories
{
    public static class AnalysisFactory
    {
        public static IAnalyze GetAnalysisAlg(int alg)
        {
            switch (alg)
            {
                case 1:
                    return new Naive();
                    break;
                case 2:
                    return new Russian();
                    break;
                case 3:
                    return null;
                case 4:
                    return null;
                default:
                    return null;
                    break;
            }
        }      
    }
}
