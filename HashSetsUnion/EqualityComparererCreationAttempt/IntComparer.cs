using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetsUnion.EqualityComparererCreationAttempt
{
    internal class IntComparer : IEqualityComparer<int>
    {
        public bool Equals(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] int obj)
        {
            return obj.GetHashCode();
        }
    }
}
