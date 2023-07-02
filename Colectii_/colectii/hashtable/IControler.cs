using Colectii.colectii.hashtable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii_.colectii.hashtable
{
    public interface IControler<K,V>
    {
        int hashKey(K key);

        void load();

        void afisare();

        void update(K key, V newValue);

        void remove(K key);

        bool occupied(int poz);

        void add(K key,V value);

    }
}
