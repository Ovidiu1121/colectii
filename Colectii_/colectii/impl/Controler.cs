using Colectii.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colectii.utils;

namespace Colectii.colectii.impl
{
    public class Controler
    {

        private ILista<Programare> lista = new Lista<Programare>();
        private Node<Programare> head;

        public Controler()
        {
            load();
            head=lista.getIterator();
        }

        public void load()
        {
            Programare a = new Programare("Alex", "mihai", "str noua", new DateTime(2016, 4, 10), new DateTime(2016, 4, 1));
            Programare b = new Programare("Cosmin", "vlad", "str cinci", new DateTime(2022, 8, 2), new DateTime(2022, 8, 6));
            Programare c = new Programare("George", "max", "str doi", new DateTime(2023, 2, 10), new DateTime(2023, 2, 16));
            Programare d = new Programare("Mihai", "sergiu", "str patru", new DateTime(2023, 1, 20), new DateTime(2023, 1, 28));

            lista.addFinish(a);
            lista.addFinish(b);
            lista.addFinish(c);
            lista.addFinish(d);

        }

        public string afisare()
        {
            Node<Programare> aux = head;
            string text = "";
            while (aux != null)
            {
                text+=aux.Data.ToString()+"\n";
                aux=aux.Next;
            }
            return text;
        }

        public void updateDataInceput(Programare p, DateTime data)
        {
            Node<Programare> aux = head;

            while (aux.Next!=null)
            {
                if (aux.Data.Equals(p)==false)
                {
                    aux.Data.DataInceput=data;
                }
                aux=aux.Next;
            }

        }

        public void updateDataSfarsit(Programare p, DateTime data)
        {
            Node<Programare> aux = head;

            while (aux.Next!=null)
            {
                if (aux.Data.Equals(p)==false)
                {
                    aux.Data.DataSfarsit=data;
                }
                aux=aux.Next;
            }

        }

        public void delete(string numeDoctor, string numeClient)
        {

            if (isProgramare(numeDoctor, numeClient)==false)
            {
                throw new ProgramareSuprapunere(Constants.PROGRAMARE_NEEXISTENTA_EXCEPTION);
            }
            else
            {
                Programare p = this.getProgramare(numeDoctor, numeClient);
                int i = 0;
                Node<Programare> aux = head;

                while (aux!=null)
                {
                    if (aux.Data.CompareTo(p)==0)
                    {
                        lista.deletePosition(i);
                        return;
                    }
                    i++;
                    aux=aux.Next;
                }
            }
        }

        public void adaugare(Programare p)
        {
            if (suprapunere(p)==true)
            {
                throw new ProgramareSuprapunere(Constants.PROGRAMARE_INVALIDA_EXCEPTION);
            }
            else
            {
                lista.addFinish(p);
            }
        }

        public bool suprapunere(Programare p)
        {
            Node<Programare> aux = head;

            while (aux!=null)
            {
                if (aux.Data.Equals(p)==true)
                {
                    return true;
                }
                aux=aux.Next;
            }
            return false;
        }

        public Programare getProgramare(string numeDoctor, string numeClient)
        {
            Node<Programare> aux = head;

            while (aux!=null)
            {
                if (aux.Data.NumeDoctor.Equals(numeDoctor)&&aux.Data.NumeClient.Equals(numeClient))
                {
                    return aux.Data;
                }
                aux=aux.Next;
            }
            return null;
        }

        public bool isProgramare(string numeDoctor, string numeClient)
        {
            Node<Programare> aux = head;

            while (aux!=null)
            {
                if (aux.Data.NumeDoctor.Equals(numeDoctor)&&aux.Data.NumeClient.Equals(numeClient))
                {
                    return true;
                }
                aux=aux.Next;
            }
            return false;

        }

        public void updateProgramare(string numedoctor, string numeclient, Programare p)
        {

            if (suprapunere(p)==true)
            {
                throw new ProgramareSuprapunere(Constants.PROGRAMARE_INVALIDA_EXCEPTION);
            }
            else
            {
                Node<Programare> aux = head;

                while (aux!=null)
                {
                    if (aux.Data.NumeDoctor.Equals(numedoctor)&&aux.Data.NumeClient.Equals(numeclient))
                    {
                        aux.Data.Adresa=p.Adresa;
                        aux.Data.DataSfarsit=p.DataSfarsit;
                        aux.Data.DataInceput=p.DataInceput;
                        return;
                    }
                    aux=aux.Next;
                }
            }
        }


    }
}
