



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
        Programare p2 = new Programare("Dct 2", "alex", "adr2", new DateTime(2019, 10, 2), new DateTime(2020, 10, 6));
        Programare p3 = new Programare("Dct 3", "vlad", "adr3", new DateTime(2021, 5, 28), new DateTime(2020, 5, 30));
        Programare p4 = new Programare("Dct 4", "mihai", "adr4", new DateTime(2008, 6, 8), new DateTime(2008, 6, 14));
        Programare p5 = new Programare("Dct 5", "vlad", "adr5", new DateTime(2018, 2, 21), new DateTime(2018, 2, 23));
        Programare p6 = new Programare("Dct 6", "mihai", "adr6", new DateTime(2013, 10, 2), new DateTime(2013, 10, 6));
        Programare p7 = new Programare("Dct 7", "alex", "adr7", new DateTime(2022, 8, 28), new DateTime(2022, 8, 30));
        Programare p8 = new Programare("Dct 8", "alex", "adr8", new DateTime(2007, 1, 8), new DateTime(2008, 1, 14));

        IHashTable<Persoana, Programare> table = new ChainedHashtable<Persoana, Programare>(10);


        table.put(a, p7);
        table.put(b, p4);
        table.put(b, p6);
        table.put(c, p3);
        table.put(c, p5);

        Console.WriteLine(table.findPosition(a));

        table.print();

    }
}