using Colectii.colectii.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii_.colectii.impl
{
    public interface IStiva<T>where T :IComparable<T>
    {

        void push(T item);

        void pop();

        T peak();

        void afisare();

        Node<T> getIterator();

        bool isEmpty();

    }
}
