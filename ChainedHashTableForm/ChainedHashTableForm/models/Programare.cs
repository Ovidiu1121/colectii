using ChainedHashTableForm.data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii_.examples
{
    public class Programare : IComparable<Programare>
    {
        private int id;
        private int idClient;
        private string adresa;
        private DateTime dataInceput;
        private DateTime dataSfarsit;
        private string connectionString;
        private DataAcces dataAcces;


        public Programare()
        {
            this.dataAcces = new DataAcces();

            this.connectionString =GetConnection();
        }

        public Programare(int idClient, string adresa, DateTime dataInceput, DateTime dataSfarsit)
        {
            this.idClient = idClient;
            this.adresa = adresa;
            this.dataInceput = dataInceput;
            this.dataSfarsit = dataSfarsit;
        }

        public Programare(int id,int idClient, string adresa, DateTime dataInceput, DateTime dataSfarsit)
        {
            this.id= id;
            this.idClient = idClient;
            this.adresa = adresa;
            this.dataInceput = dataInceput;
            this.dataSfarsit = dataSfarsit;
        }

        public DateTime DataInceput
        {
            get { return this.dataInceput; }
            set { this.dataInceput=value; }
        }
        public DateTime DataSfarsit
        {
            get { return this.dataSfarsit; }
            set { this.dataSfarsit=value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id=value; }
        }
        public int IdClient
        {
            get { return this.idClient; }
            set { this.idClient=value; }
        }
        public string Adresa
        {
            get { return this.adresa; }
            set { this.adresa=value; }
        }

        public int CompareTo(Programare other)
        {
            return this.dataInceput.CompareTo(other.dataInceput);
        }

        public override bool Equals(object obj)
        {
            Programare programare = obj as Programare;

            if ((this.dataInceput >= programare.dataInceput && this.dataInceput <= programare.dataSfarsit) ||
            (this.dataSfarsit >= programare.dataInceput && this.dataSfarsit <= programare.dataSfarsit))
            {
                return true;
            }

            if (this.dataInceput <= programare.dataInceput && this.dataSfarsit >= programare.dataSfarsit)
            {
                return true;
            }

            if (this.dataInceput >= programare.dataInceput && this.dataSfarsit <= programare.dataSfarsit)
            {
                return true;
            }

            return false;

        }

        public override string ToString()
        {
            string text = "";

            text+="Id:"+this.id+", ";
            text+="Id client:"+this.idClient+", ";
            text+="Adresa:"+this.adresa+", ";
            text+="Data inceput:"+this.dataInceput+", ";
            text+="Data sfarsit:"+this.dataSfarsit;

            return text;
        }

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }
    }
}
