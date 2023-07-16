using Colectii.colectii.hashtable;
using Colectii.models;
using Colectii_.colectii.hashtable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colectii.models;
using Colectii.colectii.impl;
using Colectii;

namespace Colectii_.examples
{
    public class ControlerSimpleHashTable : IControler<Persoana, Programare>
    {
        private IHashTable<Persoana, Lista<Programare>> table;

        public ControlerSimpleHashTable()
        {
            table = new SimpleHashTable<Persoana, Lista<Programare>>(20);
            load();
        }

        public void adaugare(Persoana key, Programare value)
        {
            //daca avem cheia
            if (table.get(key)!=null)
            {
                table.get(key).addFinish(value);
            }
            else
            {
                Lista<Programare> t = new Lista<Programare>();
                t.addFinish(value);
                t.sort();
                table.put(key, t);
            }

        }

        public void afisare()
        {
            ILista<Persoana> t = table.keys();

            Node<Persoana> persoana = t.getIterator();

            while (persoana!=null)
            {
                Console.Write("Persoana ->> ");
                Console.WriteLine(persoana.Data.ToString());

                ILista<Lista<Programare>> programari = table.values();//mai multe liste de programari

                Node<Lista<Programare>> p = programari.getIterator();//lista de programari
                Console.WriteLine("Programari:");
                while (p!=null)
                {
                    Node<Programare> it = p.Data.getIterator();
                    while (it!=null)
                    {
                        if (it.Data.NumeClient.Equals(persoana.Data.Nume))
                        {
                            Console.WriteLine(it.Data.ToString());
                        }
                        it=it.Next;
                    }
                    p=p.Next;
                }
                Console.WriteLine("");
                persoana=persoana.Next;
            }

        }

        public Persoana getPersoana(string nume, int varsta)
        {
            throw new NotImplementedException();
        }

        public void load()
        {
            Persoana a = new Persoana("alex", 13, false);
            Persoana b = new Persoana("mihai", 45, true);
            Persoana c = new Persoana("vlad", 29, true);

            Programare p1 = new Programare("Dct 1", "mihai", "adr1", new DateTime(2020, 3, 23), new DateTime(2020, 3, 20));
            Programare p2 = new Programare("Dct 2", "alex", "adr1", new DateTime(2019, 10, 2), new DateTime(2020, 10, 6));
            Programare p3 = new Programare("Dct 3", "vlad", "adr1", new DateTime(2021, 5, 28), new DateTime(2020, 5, 30));
            Programare p4 = new Programare("dcr 4", "mihai", "adr4", new DateTime(2008, 6, 8), new DateTime(2008, 6, 14));
            Programare p5 = new Programare("Dct 5", "vlad", "adr1", new DateTime(2018, 2, 21), new DateTime(2018, 2, 23));
            Programare p6 = new Programare("Dct 6", "mihai", "adr1", new DateTime(2013, 10, 2), new DateTime(2013, 10, 6));
            Programare p7 = new Programare("Dct 7", "alex", "adr1", new DateTime(2022, 8, 28), new DateTime(2022, 8, 30));
            Programare p8 = new Programare("dcr 8", "alex", "adr4", new DateTime(2007, 1, 8), new DateTime(2008, 1, 14));

            Lista<Programare> lista = new Lista<Programare>();
            lista.addStart(p1);
            lista.addStart(p2);
            lista.addStart(p3);
            lista.addStart(p4);
            lista.addStart(p5);
            lista.addStart(p6);
            lista.addStart(p7);
            lista.addStart(p8);

            table.put(a, lista);
            table.put(b, lista);
            table.put(c, lista);

        }

        public void remove(Persoana key)
        {
            ILista<Persoana> lista = table.keys();

            Node<Persoana> p = lista.getIterator();

            while (p!=null)
            {
                if (p.Data.Equals(key))
                {
                    table.delete(key);
                }
                p=p.Next;
            }

        }

        public void update(Programare oldValue, Programare newValue)
        {
            ILista<Lista<Programare>> lista = table.values();

            Node<Lista<Programare>> programari = lista.getIterator();

            while (programari!=null)
            {
                Node<Programare> p = programari.Data.getIterator();

                while (p!=null)
                {
                    if (p.Data.Equals(oldValue))
                    {
                        p.Data=newValue;
                    }
                    p=p.Next;
                }
                programari=programari.Next;
            }

        }
    }
}
