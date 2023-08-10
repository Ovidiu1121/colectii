using ChainedHashTableForm.data;
using ChainedHashTableForm.exceptions;
using Colectii;
using Colectii.colectii.hashtable;
using Colectii.colectii.impl;
using Colectii.exceptions;
using Colectii.models;
using Colectii.utils;
using Colectii_.colectii.hashtable;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii_.examples
{
    public class ControlerChainedHashTable : IControler<Persoana, Programare> 
    {
        private ChainedHashtable<Persoana, Lista<Programare>> table;
        private string connectionString;
        private DataAcces dataAcces;

        public ControlerChainedHashTable()
        {
            table=new ChainedHashtable<Persoana, Lista<Programare>>(10);
            this.dataAcces = new DataAcces();
            this.connectionString =GetConnection();
            load();
        }

        public void adaugare(Programare value)
        {
           

            string sql = "insert into programari(Id,IdClient,adresa,dataInceput,dataSfarsit) value(@Id," +
                "@IdClient,@adresa,@dataInceput,@dataSfarsit)";

            this.dataAcces.SaveData(sql, new
            {
                value.Id,
                value.IdClient,
                value.Adresa,
                value.DataInceput,
                value.DataSfarsit
            }, connectionString);

        }

        public void adaugarePersoana(Persoana key)
        {

            string sql = "insert into persoane(nume,varsta,password,tip) value(@nume,@varsta,@password,@tip)";

            this.dataAcces.SaveData(sql, new
            {
                key.Nume,
                key.Varsta,
                key.Password,
                key.Tip
            }, connectionString);

        }

        public void afisare()
        {
            ILista<Persoana> a = table.keys();

            Node<Persoana> persoana = a.getIterator();

            while (persoana!=null)
            {
                Console.Write("Persoana ->> ");
                Console.WriteLine(persoana.Data.ToString());

                ILista<Lista<Programare>> lista = table.values();

                Node<Lista<Programare>> p = lista.getIterator();
                Console.WriteLine("Programari:");
                while (p!=null)
                {
                    Node<Programare> programare = p.Data.getIterator();

                    while (programare!=null)
                    {
                        if (programare.Data.IdClient.Equals(persoana.Data.Id))
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

        public Lista<Programare> getProgramariByClientId(int idClient)
        {
            Lista<Programare>lista=new Lista<Programare>();
            string sql = "select * from programari where idClient=@idClient";
           
            List<Programare> x= dataAcces.LoadData<Programare, dynamic>(sql, new {idClient}, connectionString);

            x.ForEach(el =>
            {
                lista.addStart(el);
            });

            return lista;
        }

        public List<Persoana> getAllPersoane()
        {
            string sql = "select * from persoane";

            return dataAcces.LoadData<Persoana, dynamic>(sql, new { }, connectionString);
        }

        public void load()
        {
            List<Persoana> lista = getAllPersoane();

            foreach (Persoana p in lista)
            {
                Lista<Programare> programari = getProgramariByClientId(p.Id);

                table.put(p, programari);
            }

        }

        public void remove(Persoana key)
        {
            string sql = "delete from persoane where nume=@nume";

            try
            {
                dataAcces.SaveData(sql, new { key.Nume }, connectionString);

            }catch (Exception ex)
            {
                throw new ServiceException(Constants.CONECTARE_DB_EXCEPTION);
            }
        }

        public void suprapunere(Programare programare)
        {
            ILista<Lista<Programare>> lista = table.values();

            Node<Lista<Programare>> programari = lista.getIterator();

            while (programari!=null)
            {
                Node<Programare> p = programari.Data.getIterator();

                while (p!=null)
                {
                    if (p.Data.Equals(programare))
                    {
                        throw new SuprapunereProgramareException(Constants.PROGRAMARE_INVALIDA_EXCEPTION);
                    }
                    p=p.Next;
                }
                programari=programari.Next;
            }
        }

        public void update(Programare oldValue, Programare newValue)
        {

            string sql = "update programari set adresa=@adresa,dataInceput=@dataInceput," +
                "dataSfarsit=@dataSfarsit where id=@id";

            try
            {
                this.dataAcces.SaveData(sql, new
                {
                    newValue.Adresa,
                    newValue.DataInceput,
                    newValue.DataSfarsit,
                    oldValue.Id
                }, connectionString);

            }
            catch (Exception ex)
            {
                throw new ServiceException(Constants.CONECTARE_DB_EXCEPTION);
            }

        }

        public Persoana getPersoana(string nume,string password)
        {
            ILista<Persoana> a = table.keys();

            Node<Persoana> p = a.getIterator();

            while (p!=null)
            {

                if (p.Data.Password.Equals(password)&&p.Data.Nume.Equals(nume))
                {
                    return p.Data;
                }
                p=p.Next;
            }
            return null;
        }

        public bool isPersoana(string nume, string password)
        {

            ILista<Persoana> a = table.keys();

            Node<Persoana> p = a.getIterator();

            while (p!=null)
            {
                if (p.Data.Nume.Equals(nume)&&p.Data.Password.Equals(password))
                {
                    return true;
                }
                p=p.Next;
            }
            return false;
        }

        public ILista<Programare> getProgramari(Persoana key)
        {

            ILista<Programare>ls=new Lista<Programare>();

            ILista<Lista<Programare>> lista = table.values();

            Node<Lista<Programare>> p = lista.getIterator();
            while (p!=null)
            {
                Node<Programare> programare = p.Data.getIterator();

                while (programare!=null)
                {
                    if (programare.Data.IdClient.Equals(key.Nume))
                    {
                        ls.addFinish(programare.Data);
                    }
                    programare=programare.Next;
                }
                p=p.Next;
            }

            return ls;

        }

        public Programare getProgramare(DateTime datainceput)
        {
            string sql = "select * from programari where dataInceput=@dataInceput";

            Lista<Programare> lista = new Lista<Programare>();

            List<Programare> x = dataAcces.LoadData<Programare, dynamic>(sql, new { datainceput }, connectionString);

            x.ForEach(el =>
            {
                lista.addFinish(el);

            });

            Node<Programare> node=lista.getIterator();

            return node.Data;
          
        }

        public void removeProgramare(Programare value)
        {

            string sql = "delete from programari where dataInceput=@dataInceput";

            try
            {

                this.dataAcces.SaveData(sql, new { value.DataInceput }, connectionString);
            }catch (Exception ex)
            {
                throw new ServiceException(Constants.CONECTARE_DB_EXCEPTION);
            }
        }

        public string getNume(int id)
        {

            ILista<Persoana> a = table.keys();

            Node<Persoana> p = a.getIterator();

            while (p!=null)
            {

                if (p.Data.Id.Equals(id))
                {
                    return p.Data.Nume;
                }
                p=p.Next;
            }
            return null;

        }

        public bool addProgramareInPauza(Persoana persoana,Programare programare)
        {

            ILista<Programare> ls = new Lista<Programare>();

            ILista<Lista<Programare>> lista = table.values();

            Node<Lista<Programare>> x = lista.getIterator();
            while (x!=null)
            {
                Node<Programare> p = x.Data.getIterator();

                while (p!=null)
                {
                    if (p.Data.IdClient.Equals(persoana.Id))
                    {
                        if (programare.DataInceput.Month.Equals(p.Data.DataSfarsit.Month)&&programare.DataInceput.Year.Equals(p.Data.DataSfarsit.Year))
                        {
                            if (programare.DataInceput.Day<=p.Data.DataSfarsit.Day+10&&programare.DataInceput.Day>p.Data.DataSfarsit.Day)
                            {
                                return true;
                            }
                        }
                    }
                    p=p.Next;
                }
                x=x.Next;
            }
            return false;
        }

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }

        public Persoana findbyId(int id)
        {

            ILista<Persoana> a = table.keys();

            Node<Persoana> p = a.getIterator();

            while (p!=null)
            {

                if (p.Data.Id.Equals(id))
                {
                    return p.Data;
                }
                p=p.Next;
            }
            return null;

        }


    }
}
