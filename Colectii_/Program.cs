



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


        IControler<Persoana, Programare> table = new ControlerSimpleHashTable<Persoana, Programare>(10);



    }
}