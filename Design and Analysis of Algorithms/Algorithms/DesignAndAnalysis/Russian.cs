using Design_and_Analysis_of_Algorithms.Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Algorithms.DesignAndAnalysis
{
    public class Russian : IAnalyze
    {
        public int Compute(int a, int b)
        {
            //example Russian(14,11)
            //x  y  z
            //14 11 0
            //7  22 0
            //3  44 22
            //1  88 66
            //0 176 154



            int x = a;
            int y = b;
            int z = 0;

            while (x > 0)
            {
                if( x % 2 == 1)
                {
                    z = z + y;
                    y = y << 1;
                    x = x >> 1;
                }
                else
                {
                    y = y << 1;
                    x = x >> 1;
                }
              
            }
            return z;
        }
    }
}
