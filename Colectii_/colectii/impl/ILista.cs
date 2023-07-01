using Colectii.colectii.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii
{
    public interface ILista<T> where T : IComparable<T>
    {
        void afisare();
        void addPosition(T item, int poz);
        void addStart(T item);
        void addFinish(T item);
        void deletePosition(int poz);
        void deleteStart();
        void deleteFinish();
        int position(T item);
        int size();
        void sort();
        Node<T> getIterator();

    }
}
