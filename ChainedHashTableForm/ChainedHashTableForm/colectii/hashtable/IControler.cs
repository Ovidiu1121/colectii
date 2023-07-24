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

        void adaugare(V value);

        K getPersoana(string password);

        bool isPersoana(string nume, string password);

        ILista<V> getProgramari(K key);

        V getProgramare(DateTime datainceput);

    }
}
