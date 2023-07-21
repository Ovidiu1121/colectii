using Colectii;
using Colectii.colectii.hashtable;
using Colectii.models;
using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii_.colectii.hashtable
{
    public interface IControler<K, V>where V:IComparable<V>
    {

        void load();

        void afisare();

        void update(V oldValue, V newValue);

        void remove(K key);

        void removeProgramare(V value);

        void adaugare(K key, V value);

        K getPersoana(string nume,int varsta);

        bool isPersoana(string nume, int varsta);

        ILista<V> getProgramari(K key);

        V getProgramare(K key,DateTime datainceput);

    }
}
