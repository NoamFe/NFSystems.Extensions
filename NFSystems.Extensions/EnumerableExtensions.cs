using System.Collections.Generic;
using System.Linq; 

namespace NFSystems.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> value)
        {
            return !value.Any();
        }
    }
}
