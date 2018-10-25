using System;
using System.Collections.Generic;

namespace BimKon.Core.Models
{
    public class Grouping<K, T> : List<T>
    {
        public K Key { get; set; }

        public Grouping(K key, IEnumerable<T> items)
        {
            Key = key;

            foreach (var item in items)
                Add(item);
        }

        public Grouping()
        {

        }
    }
}
