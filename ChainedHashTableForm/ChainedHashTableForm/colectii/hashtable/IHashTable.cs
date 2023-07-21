using Colectii.models;
using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.colectii.hashtable
{
    public interface IHashTable<K, V> where V : IComparable<V> where K : IComparable<K>
    {
        int hashKey(K key);

        void put(K key, V value);

        int findPosition(K key);

        V get(K key);

        void print();

        ILista<K> keys();

        ILista<V> values();

        void delete(K key);

    }
}
