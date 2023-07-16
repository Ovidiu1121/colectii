using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.colectii.hashtable
{
    public class Stored<K, V> : IComparable<Stored<K, V>>
    {
        private K key;
        private V value;

        public K Key { get => this.key; set => this.key = value; }
        public V Value { get => this.value; set => this.value=value; }

        public Stored(K key, V value)
        {
            this.key = key;
            this.value = value;
        }

        public int CompareTo(Stored<K, V> other)
        {

            return 1;
        }
    }
}

