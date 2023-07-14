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

        void load();

        void afisare();

        void update(V oldValue, V newValue);

        void remove(K key);

        void adaugare(K key,V value);

    }
}
