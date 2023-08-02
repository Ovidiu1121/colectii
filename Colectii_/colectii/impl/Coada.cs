using Colectii_.colectii.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.colectii.impl
{
    public class Coada<T> : ICoada<T> where T : IComparable<T>
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

        public void afisare()
        {
            while (node!=null)
            {
                Console.WriteLine(node.Data.ToString());
                node=node.Next;
            }
        }

        public Node<T> getIterator()
        {
            return node;
        }
    }
}
