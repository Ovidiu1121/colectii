using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii_.examples
{
    public class Programare : IComparable<Programare>
    {
        private string numeDoctor;
        private string numeClient;
        private string adresa;
        private DateTime dataInceput;
        private DateTime dataSfarsit;

        public Programare()
        {

        }

        public Programare(string numeDoctor, string numeClient, string adresa, DateTime dataInceput, DateTime dataSfarsit)
        {
            this.numeDoctor = numeDoctor;
            this.numeClient = numeClient;
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
        public string NumeDoctor
        {
            get { return this.numeDoctor; }
            set { this.numeDoctor=value; }
        }
        public string NumeClient
        {
            get { return this.numeClient; }
            set { this.numeClient=value; }
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

            text+="Nume doctor:"+this.numeDoctor+", ";
            text+="Nume client:"+this.numeClient+", ";
            text+="Adresa:"+this.adresa+", ";
            text+="Data inceput:"+this.dataInceput+", ";
            text+="Data sfarsit:"+this.dataSfarsit;

            return text;
        }


    }
}
