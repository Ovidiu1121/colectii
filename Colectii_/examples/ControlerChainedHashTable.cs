﻿using Colectii;
using Colectii.colectii.hashtable;
using Colectii.colectii.impl;
using Colectii.models;
using Colectii_.colectii.hashtable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii_.examples
{
    public class ControlerChainedHashTable : IControler<Persoana, Programare>
    {
        private IHashTable<Persoana, Lista<Programare>> table;

        public ControlerChainedHashTable()
        {
            table=new ChainedHashtable<Persoana, Lista<Programare>>(10);
            load();
        }

        public void adaugare(Persoana key, Programare value)
        {

            if(table.get(key) != null)
            {
                table.get(key).addFinish(value);
            }
            else
            {
                Lista<Programare> lista = new Lista<Programare>();
                    
                lista.addFinish(value);
                lista.sort();
                table.put(key, lista);

            }

        }

        public void afisare()
        {
            ILista<Persoana>a=table.keys();

            Node<Persoana>persoana=a.getIterator();

            while (persoana!=null)
            {
                Console.Write("Persoana ->> ");
                Console.WriteLine(persoana.Data.ToString());

                ILista<Lista<Programare>> lista = table.values();

                Node<Lista<Programare>>p=lista.getIterator();
                Console.WriteLine("Programari:");
                while (p!=null)
                {
                    Node<Programare>programare=p.Data.getIterator();

                    while (programare!=null)
                    {
                        if (programare.Data.NumeClient.Equals(persoana.Data.Nume))
                        {
                            Console.WriteLine(programare.Data.ToString());
                        }
                        programare=programare.Next;
                    }
                    p=p.Next;
                }
                persoana=persoana.Next;
            }

        }

        public void load()
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
            table.delete(key);
        }

        public void update(Programare oldValue, Programare newValue)
        {
           
            ILista<Lista<Programare>>lista=table.values();

            Node<Lista<Programare>>programari=lista.getIterator();

            while (programari!=null)
            {
                Node<Programare>p=programari.Data.getIterator();

                while (p!=null)
                {
                    if (p.Data.Equals(oldValue))
                    {
                        p.Data=newValue;
                        return;
                    }
                    p=p.Next;
                }
                programari=programari.Next;
            }

        }
    }
}
