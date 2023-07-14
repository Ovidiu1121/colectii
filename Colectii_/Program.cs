



using Colectii;
using Colectii.colectii.hashtable;
using Colectii.colectii.impl;
using Colectii.models;
using Colectii_.colectii.hashtable;
using Colectii_.examples;

class Program
{
    static void Main(string[] args)
    {

       ControlerChainedHashTable c=new ControlerChainedHashTable();

        Programare p1 = new Programare("Dct 3", "vlad", "adr3", new DateTime(2021, 5, 28), new DateTime(2020, 5, 30));
        Programare p2 = new Programare("Dct 3", "vlad", "sadasfasd", new DateTime(2011, 5, 28), new DateTime(2011, 5, 30));

        c.update(p1, p2);

        c.afisare();

    }
}