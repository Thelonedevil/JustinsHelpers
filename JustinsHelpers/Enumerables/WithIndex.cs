using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustinsHelpers.Enumerables.WithIndex
{
   public static class Helper
    {
        public static IEnumerable<(TModel Item, int Index)> WithIndex<TModel>(this IEnumerable<TModel> source,bool StartAtOne=false)
        {
            if (!source.Any())
            {
                throw new ArgumentException($"{nameof(source)} cannot be empty.", nameof(source));
            }
            if (StartAtOne)
            {
                return source.Select((a, i) => (Item:a, Index:i + 1));
            }
            else
            {
                return source.Select((a, i) => (Item:a, Index:i));
            }
        }
    }
}
