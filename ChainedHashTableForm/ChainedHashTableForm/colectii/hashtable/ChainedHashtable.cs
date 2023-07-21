using Colectii;
using Colectii.colectii.hashtable;
using Colectii.colectii.impl;
using Colectii.models;
using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii_.colectii.hashtable
{
    public class ChainedHashtable<K, V> : IHashTable<K, V> where K : IComparable<K> where V : IComparable<V>
    {
        private ILista<Stored<K, V>>[] hashtable;

        public ChainedHashtable(int size)
        {
            this.hashtable = new Lista<Stored<K, V>>[size];
            for (int i = 0; i < size; i++)
                hashtable[i] = new Lista<Stored<K, V>>();
        }

        public void delete(K key)
        {
            int hashedKey = hashKey(key), i = 0;
            Node<Stored<K, V>> head = hashtable[hashedKey].First();
            while (head != null)
            {
                if (head.Data.Key.Equals(key))
                {
                    hashtable[hashedKey].deletePosition(i);
                }
                i++;
                head = head.Next;
            }
            //Console.WriteLine("Key does not exist");
        }

        public int findPosition(K key, bool show)
        {
            int hashedKey = hashKey(key);
            if (show)
                Console.Write(hashedKey.ToString() + "->");
            Node<Stored<K, V>> head = hashtable[hashedKey].First();
            int p = 0;
            while (head != null)
            {
                if (head.Data.Key.Equals(key))
                    return p;
                p++;
                head = head.Next;
            }
            return -1;
        }

        public int findPosition(K key)
        {
            return findPosition(key, true);
        }

        public V get(K key)
        {
            int hashedKey = hashKey(key);
            Node<Stored<K, V>> head = hashtable[hashedKey].First();
            while (head != null)
            {
                if (head.Data.Key.Equals(key))
                    return head.Data.Value;
                head = head.Next;
            }
            return default(V);
        }

        public int hashKey(K key)
        {
            return key.ToString().Length % hashtable.Length;
        }

        public ILista<K> keys()
        {
            ILista<K> lista = new Lista<K>();

            for (int i = 0; i<hashtable.Length; i++)
            {
                Node<Stored<K, V>> head = hashtable[i].First();

                while (head != null)
                {
                    if (head.Data.Key != null)
                    {
                        lista.addFinish(head.Data.Key);
                    }
                    head=head.Next;
                }
            }
            return lista;
        }

        public void print()
        {
            for (int i = 0; i < hashtable.Length; i++)
            {

                if (hashtable[i].isEmpty())
                {
                    hashtable[i].afisare();
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(i + ": ");
                    Node<Stored<K, V>> head = hashtable[i].First();
                    while (head != null)
                    {
                        Console.WriteLine(head.Data.Key);
                        Console.WriteLine("-->" + head.Data.Value);
                        head = head.Next;
                    }
                }
            }
        }

        public void put(K key, V value)
        {
            int hashedKey = hashKey(key);
            Stored<K, V> data = new Stored<K, V>(key, value);
            hashtable[hashedKey].addFinish(data);
        }

        public ILista<V> values()
        {
            ILista<V> lista = new Lista<V>();

            for (int i = 0; i<hashtable.Length; i++)
            {
                Node<Stored<K, V>> head = hashtable[i].First();

                while (head != null)
                {
                    if (head.Data.Value != null)
                    {
                        lista.addFinish(head.Data.Value);
                    }
                    head=head.Next;
                }
            }
            return lista;
        }
    }
}
