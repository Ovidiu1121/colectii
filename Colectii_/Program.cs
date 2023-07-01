



using Colectii.colectii.hashtable;
using Colectii.models;

class Program
{
    static void Main(string[] args)
    {
        Masina a = new Masina("audi", "alb", 2001);
        Masina b = new Masina("bmw", "gri", 2011);
        Masina c = new Masina("ferarri", "negru", 2023);
        Masina d = new Masina("bentley", "roz", 2004);
        Masina e = new Masina("ford", "maro", 2019);
        Masina f = new Masina("dacia", "alb", 1300);

        IHashTable<String, Masina> table = new SimpleHashTable<String, Masina>(10);

        table.put("aa", a);
        table.put("aaa", b);
        table.put("bbbbb", c);
        table.put("cc", d);
        table.put("dddd", e);
        table.put("ee", f);

        table.print();
        Console.WriteLine(table.findPosition("ee"));
        Console.WriteLine(table.get("ee").ToString());

    }
}