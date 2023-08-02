using Colectii_.colectii.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.colectii.impl
{
    public class Stiva<T> : IStiva<T> where T : IComparable<T>
    {
        Node<T> node = null;

        public void push(T item)
        {
            Node<T> aux = new Node<T>();
            aux.Data=item;
            aux.Next=node;
            node = aux;
        }

        public bool isEmpty()
        {
            return node == null;
        }

        public void pop()
        {
            if (isEmpty() == true)
            {
                return;
            }
            else
            {
                Node<T> aux = node;
                node=node.Next;
                aux=null;
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
            Node<T> aux = node;
            while (aux!=null)
            {
                Console.WriteLine(aux.Data);
                aux=aux.Next;
            }
        }

        public Node<T> getIterator()
        {
            return node;
        }

    }
}
