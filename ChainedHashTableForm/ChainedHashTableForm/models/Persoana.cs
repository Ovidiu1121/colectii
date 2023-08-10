using ChainedHashTableForm.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.models
{
    public class Persoana : IComparable<Persoana>,IPersoanaBuilder
    {
        private int id;
        private string nume;
        private int varsta;
        private string password;
        private int tip;

        public Persoana()
        {

        }

        public Persoana(string nume, int varsta, string password, int tip)
        {
            this.nume=nume;
            this.varsta=varsta;
            this.password=password;
            this.tip=tip;
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }
        public int Varsta
        {
            get { return this.varsta; }
            set { this.varsta = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Tip
        {
            get { return this.tip; }
            set { this.tip = value; }
        }

        public override string ToString()
        {
            string text = "";

            text+="Id:"+this.id+", ";
            text+="Nume:"+this.nume+", ";
            text+="Varsta:"+this.varsta+", ";
            text+="Parola:"+this.password;

            return this.nume;
        }
        public int CompareTo(Persoana other)
        {

            if (this.varsta>other.varsta)
            {
                return 1;
            }
            else if (this.varsta==other.varsta)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }
        public override bool Equals(object obj)
        {
            Persoana p = obj as Persoana;

            return p.nume.Equals(this.nume);
        }

        public Persoana setId(int id)
        {
            this.id = id;
            return this;
        }
        public Persoana setNume(string nume)
        {
            this.nume = nume;
            return this;
        }
        public Persoana setVarsta(int varsta)
        {
           this.varsta = varsta;
            return this;
        }
        public Persoana setpassword(string password)
        {
           this.password = password;
            return this;
        }
        public Persoana setTip(int tip)
        {
            this.tip = tip;
            return this;
        }
        public static Persoana buid()
        {
            return new Persoana();
        }
    }
}
