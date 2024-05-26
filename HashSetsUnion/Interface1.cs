using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetsUnion
{
    internal interface Interface1<in T>
    {
        int GetHashCode();
        int GetHashCode(T obj);
    }
}
