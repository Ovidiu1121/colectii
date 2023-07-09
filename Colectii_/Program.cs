



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

        Persoana a = new Persoana("alex", 13, false);
        Persoana b = new Persoana("mihai", 45, true);
        Persoana c = new Persoana("vlad", 29, true);

        Programare p1 = new Programare("Dct 1", "mihai", "adr1", new DateTime(2020, 3, 23), new DateTime(2020, 3, 20));
        Programare p2 = new Programare("Dct 2", "alex", "adr1", new DateTime(2019, 10, 2), new DateTime(2020, 10, 6));
        Programare p3 = new Programare("Dct 3", "vlad", "adr1", new DateTime(2021, 5, 28), new DateTime(2020, 5, 30));


        IHashTable<Persoana, Programare> chain = new ChainedHashtable<Persoana, Programare>(10);

        chain.put(a, p2);
        chain.put(b, p1);
        chain.put(c, p3);

        ILista<Persoana> lista=chain.keys();

        lista.afisare();

    }
}