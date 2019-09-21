using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JustinsHelpers.Enumerables.WithIndex;

namespace JustinsHelpers.Tuples.AsEnumerable
{
    public static class Helper
    {
        public static IEnumerable<object> AsEnumerable<TModel>(this TModel tuple)
        {
            if (tuple.GetType().GetInterface("ITuple") != null)
            {
                var items = tuple.GetType()
                    .GetFields()
                    .Where(x => x.Name.StartsWith("Item") || x.Name=="Rest").WithIndex();
                foreach (var (prop,index) in items)
                {
                    var value = prop.GetValue(tuple);
                    if (index == 7)
                    {
                        if (value.GetType().GetInterface("ITuple") != null)
                        {
                            foreach (var item in AsEnumerable(value))
                            {
                                yield return item;
                            }
                        }
                    }
                    else
                    {
                        yield return value;
                    }
                    
                       
                    
                }
            }
            else
            {
                throw new ArgumentException("Not a tuple!");
            }
        }
    }
}
