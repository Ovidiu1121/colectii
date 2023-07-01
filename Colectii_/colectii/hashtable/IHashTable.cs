using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.colectii.hashtable
{
    public interface IHashTable<K, V>
    {
        int hashKey(K key);

        void put(K key, V value);

        int findPosition(K key);

        V get(K key);

        void print();

        bool occupied(int position);

    }
}
