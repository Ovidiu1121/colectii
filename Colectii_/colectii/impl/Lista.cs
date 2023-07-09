using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.colectii.impl
{
    public class Lista<T> : ILista<T> where T : IComparable<T>  
    {

        Node<T> node = null;


        public void addFinish(T item)
        {
            Node<T> test = node;

            while (test!=null)
            {
                if (test.Data.CompareTo(item)==0)
                {
                    return;
                }
                test = test.Next;
            }

            if (node == null)
            {
                node=new Node<T>();
                node.Data = item;
                node.Next=null;
            }
            else
            {
                Node<T> nou = node;

                while (nou.Next!=null)
                {
                    nou=nou.Next;
                }
                Node<T> aux = new Node<T>();

                aux.Data = item;
                aux.Next = null;
                nou.Next = aux;

            }
        }

        public void addPosition(T item, int poz)
        {
            if (poz==0)
            {
                addStart(item);
            }
            else
            {
                Node<T> nou = node;
                int ct = 0;

                while (nou!=null&&ct!=poz-1)
                {
                    nou=nou.Next;
                    ct++;
                }

                Node<T> aux = new Node<T>();
                aux.Next=nou.Next;
                nou.Next=aux;
                aux.Data = item;

            }

        }

        public void addStart(T item)
        {
            Node<T> aux = node;

            while (aux!=null)
            {
                if (aux.Data.CompareTo(item)==0)
                {
                    return;
                }
                aux=aux.Next;
            }

            if (node == null)
            {
                node = new Node<T>();
                node.Data = item;
                node.Next = null;
            }
            else
            {
                Node<T> nou = new Node<T>();
                nou.Data = item;
                nou.Next = node;
                node=nou;
            }

        }

        public void afisare()
        {
            while (node!=null)
            {
                Console.WriteLine(node.Data.ToString());
                node=node.Next;
            }
        }

        public int CompareTo(ILista<T>? other)
        {
            if (this.size()>other.size())
            {
                return 1;
            }else if (this.size()<other.size())
            {
                return -1;
            }

            return 0;
        }

        public void delete(T data)
        {
            Node<T> aux = node;

            if (aux.Data.Equals(data))
            {
                deletePosition(0);
            }

            while (aux!=null)
            {
                if (aux.Next.Data.Equals(data))
                {
                    if (aux.Next.Next==null)
                    {
                        aux.Next=null;
                        return;
                    }
                    aux.Next=aux.Next.Next;
                    return;
                }
                aux=aux.Next;
            }

        }

        public void deleteFinish()
        {
            Node<T> nou = node;

            if (nou==null)
            {
                return;
            }

            while (nou.Next.Next!=null)
            {
                nou=nou.Next;
            }
            nou.Next=null;
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

        public Node<T> First()
        {
            return node;
        }

        public Node<T> getIterator()
        {
            return node;
        }

        public bool isEmpty()
        {
            Node<T> aux = node;

            return aux==null;
        }

        public int position(T item)
        {
            Node<T> aux = node;
            int ct = 0;

            while (aux!=null)
            {
                if (aux.Data.Equals(item)==true)
                {
                    return ct;
                }
                ct++;
                aux=aux.Next;
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
    }
}
