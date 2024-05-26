using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetsUnion.EqualityComparererCreationAttempt
{
    internal class Comparer : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }
    }
}
