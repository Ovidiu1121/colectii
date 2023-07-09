using Colectii.colectii.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.colectii.hashtable
{
    public class SimpleHashTable<K, V> : IHashTable<K, V> where K:IComparable<K> where V:IComparable<V>
    {
        private Stored<K, V>[] hashtable;

        public SimpleHashTable()
        {

        }

        public SimpleHashTable(int size)
        {
            this.hashtable=new Stored<K, V>[size];
        }

        public int findPosition(K key)
        {

            int hashedkey = hashKey(key);

            if (hashtable[hashedkey]!=null&&hashtable[hashedkey].Key.Equals(key))
            {
                return hashedkey;
            }

            int stopIndex = hashedkey;

            if (hashedkey==hashtable.Length-1)
            {
                hashedkey = 0;
            }
            else
            {
                hashedkey++;
            }

            while (hashedkey!=stopIndex&&hashtable[hashedkey]!=null&&!hashtable[hashedkey].Key.Equals(key))
            {
                hashedkey=(hashedkey+1)%hashtable.Length;
            }

            if (hashtable[hashedkey]!=null&&hashtable[hashedkey].Key.Equals(key))
            {
                return hashedkey;
            }
            else
            {
                return -1;
            }

        }

        public V get(K key)
        {

            int hashedkey = findPosition(key);

            if (hashedkey==-1)
            {
                return default(V);
            }

            return hashtable[hashedkey].Value;

        }

        public int hashKey(K key)
        {
            return key.ToString().Length % hashtable.Length;
        }

        public bool occupied(int position)
        {
            return hashtable[position]!=null;
        }

        public void print()
        {
            for (int i = 0; i<hashtable.Length; i++)
            {

                if (hashtable[i]!=null)
                {
                    Console.Write(i+":");
                    Console.WriteLine(hashtable[i].Key);
                    Console.Write(hashtable[i].Value);

                }
                else
                {
                    Console.WriteLine("null");
                }
                Console.WriteLine("");
            }


        }

        public void put(K key, V value)
        {

            int hashedkey = hashKey(key);

            if (occupied(hashedkey))
            {
                int stopIndex = hashedkey;

                if (hashedkey==hashtable.Length-1)
                {
                    hashedkey=0;
                }
                else
                {
                    hashedkey++;
                }

                while (occupied(hashedkey)&&hashedkey!=stopIndex)
                {
                    hashedkey=(hashedkey+1)%hashtable.Length;
                }
            }

            if (occupied(hashedkey))
            {
                Console.WriteLine("There are no more free spaces");
            }
            else
            {
                hashtable[hashedkey]=new Stored<K, V>(key, value);
            }
        }

        public IList<Stored<K, V>> storeds()
        {
            IList<Stored<K,V>> lista = new List<Stored<K, V>>();

            for (int i = 0; i<hashtable.Length; i++)
            {
                if (hashtable[i]!=null)
                {
                    lista.Add(hashtable[i]);
                }
            }
            return lista;
        }

        public ILista<K> keys()
        {
            ILista<K> lista = new Lista<K>();

            for (int i = 0; i<hashtable.Length; i++)
            {
                if (hashtable[i]!=null)
                {
                    lista.addFinish(hashtable[i].Key);
                }
            }
            return lista;
        }

        public ILista<V> values()
        {
            ILista<V> lista = new Lista<V>();

            for (int i = 0; i<hashtable.Length; i++)
            {
                if (hashtable[i]!=null)
                {
                    lista.addFinish(hashtable[i].Value);
                }
            }
            return lista;
        }

        public void delete(K key)
        {
            int hashedkey = findPosition(key);

            hashtable[hashedkey] = null;

        }
    }
}
