using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_and_Analysis_of_Algorithms.Algorithms.Interfaces
{
    public interface ISort
    {
         void Sort(IComparable[] a);
         object[] Sort(object[] a);
    }
}
