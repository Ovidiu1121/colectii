using Colectii.colectii.hashtable;
using Colectii.models;
using Colectii_.colectii.hashtable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colectii.models;
using Colectii.colectii.impl;

namespace Colectii_.examples
{
    public class ControlerSimpleHashTable : IControler<Persoana, Lista<Programare>>
    {
        private SimpleHashTable<Persoana,Lista<Programare>> table;
        public void add(Persoana key, Lista<Programare> value)
        {
            throw new NotImplementedException();
        }

        public void afisare()
        {
            throw new NotImplementedException();
        }

        public int hashKey(Persoana key)
        {
            throw new NotImplementedException();
        }

        public void load()
        {
            throw new NotImplementedException();
        }

        public bool occupied(int poz)
        {
            throw new NotImplementedException();
        }

        public void remove(Persoana key)
        {
            throw new NotImplementedException();
        }

        public void update(Persoana key, Lista<Programare> newValue)
        {
            throw new NotImplementedException();
        }
    }
}
