using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.models
{
    public class Persoana : IComparable<Persoana>
    {
        private int id;
        private string nume;
        private int varsta;
        private string password;

        public Persoana()
        {

        }

        public Persoana(string nume, int varsta, string password)
        {
            this.nume=nume;
            this.varsta=varsta;
            this.password=password;
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

    }
}
