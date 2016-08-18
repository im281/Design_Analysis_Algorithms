using Design_and_Analysis_of_Algorithms.Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Algorithms.DesignAndAnalysis
{
    public class Naive : IAnalyze
    {
        public int Compute(int a, int b)
        {
            //PROOF
            //before and after the loop ab = xy + z 
            //Base case: z = 0 then ab = ab
            //Inductive step: If before while ab = xy + z then after while ab = x'y' + z'
            //during loop: 
            //x' = x -1
            //y' = y
            //z' = z + y
            //so: x'y' + z' = (x -1) * y + (z + y)
            //x'y' + z' = xy - y + z + y
            //x'y' + z' = xy + z 
            //So
            //when x = 0 then ab = z

            //test
            //test 2

            int x = a;
            int y = b;
            int z = 0;
           
            while (x > 0)
            {
                z = z + y;
                x = x - 1;
            }
            return z;
        }
    }
}
 