using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.colectii.impl
{
    public class Coada<T> : ILista<T> where T : IComparable<T>
    {
        Node<T> node = null;

        public bool isEmpty()
        {
            if (node == null)
            {
                return true;
            }
            return false;
        }

        public void push(T x)
        {
            if (isEmpty() == true)
            {
                node = new Node<T>();
                node.Data = x;
                node.Next = null;
            }
            else
            {

                Node<T> nou = node;

                while (nou.Next!=null)
                {
                    nou = nou.Next;
                }

                Node<T> aux = new Node<T>();

                aux.Data = x;
                aux.Next = null;
                nou.Next = aux;
            }

        }

        public void pop()
        {

            if (isEmpty() == true)
            {
                return;
            }
            else
            {
                node=node.Next;
            }
        }

        public T peak()
        {
            if (isEmpty() == true)
            {
                return default(T);
            }
            return node.Data;
        }

        public void addFinish(T item)
        {
            Node<T> aux = node;
            while (aux.Next!=null)
            {
                aux = aux.Next;
            }

            Node<T> nou = new Node<T> { Data = item, Next=null };
            aux.Next = nou;

        }

        public void addPosition(T item, int poz)
        {
            int ct = 1;
            Node<T> aux = node;

            if (poz==0)
            {
                addStart(item);
            }
            else
            {
                while (aux.Next!=null)
                {
                    if (ct==poz)
                    {
                        Node<T> nou = new Node<T>();
                        nou.Data = item;
                        nou.Next=aux.Next;
                        aux.Next=nou;
                        break;
                    }
                    ct++;
                    aux=aux.Next;
                }
            }

        }

        public void addStart(T item)
        {
            Node<T> nou = new Node<T>();
            nou.Data = item;
            nou.Next = node;

            node = nou;
        }

        public void afisare()
        {
            while (node!=null)
            {
                Console.WriteLine(node.Data.ToString());
                node=node.Next;
            }
        }

        public void deleteFinish()
        {
            Node<T> aux = node;
            while (aux.Next.Next!=null)
            {
                aux=aux.Next;
            }
            aux.Next=null;
        }

        public void deletePosition(int poz)
        {
            Node<T> nou = node;
            int ct = 0;

            if (poz==0)
            {
                deleteStart();
            }
            else
            {
                while (nou!=null&&ct!=poz-1)
                {
                    ct++;
                    nou=nou.Next;
                }
                nou.Next=nou.Next.Next;
            }
        }

        public void deleteStart()
        {
            node=node.Next;
        }

        public int position(T item)
        {
            int ct = 0;

            while (node!=null)
            {
                if (node.Data.Equals(item)==true)
                {
                    return ct;
                }
                ct++;
                node=node.Next;
            }
            return -1;
        }

        public int size()
        {
            int ct = 0;

            if (node ==null)
            {
                return 0;
            }

            Node<T> nou = node;

            while (nou!=null)
            {
                ct++;
                nou = nou.Next;
            }
            return ct;
        }

        public void sort()
        {
            Node<T> aux = node;

            while (aux != null)
            {
                Node<T> minim = aux;
                Node<T> urm = aux.Next;

                while (urm != null)
                {
                    if (urm.Data.CompareTo(minim.Data) < 0)
                    {
                        minim = urm;
                    }
                    urm = urm.Next;
                }

                if (minim != aux)
                {
                    T item = aux.Data;
                    aux.Data = minim.Data;
                    minim.Data = item;
                }

                aux = aux.Next;
            }

        }

        public Node<T> getIterator()
        {
            return node;
        }
    }
}
