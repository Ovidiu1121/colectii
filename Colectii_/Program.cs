



using Colectii.models;
using Colectii_.colectii.hashtable;
using Colectii_.examples;

class Program
{
    static void Main(string[] args)
    {
        Persoana a = new Persoana("alex",13,false);
        Persoana b = new Persoana("mihai",45,true);
        Persoana c = new Persoana("vlad",29,true);
        Persoana d = new Persoana("ana",42,false);
        Persoana e = new Persoana("george",38,false);
        Persoana f = new Persoana("dan",19,true);

        Programare p1 = new Programare("Dct 1", "dan", "adr1", new DateTime(2020, 3, 23), new DateTime(2020, 3, 20));
        Programare p2 = new Programare("Dct 2", "alex", "adr1", new DateTime(2019, 10, 2), new DateTime(2020, 10,6));
        Programare p3 = new Programare("Dct 3", "ana", "adr1", new DateTime(2021, 5, 28), new DateTime(2020, 5, 30));
        Programare p4 = new Programare("dcr 4", "mihai", "adr4", new DateTime(2008, 6, 8), new DateTime(2008, 6, 14));

        IControler<Persoana, Programare> table = new ControlerSimpleHashTable<Persoana, Programare>(10);

        table.add(a,p1);
        table.add(b,p2);
        table.add(c,p3);
        table.add(d,p4);

        table.remove(b);
        table.afisare();

    }
}