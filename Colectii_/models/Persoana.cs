using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.models
{
    public class Persoana : IComparable<Persoana>
    {
        private string nume;
        private int varsta;
        private bool angajat;

        public Persoana()
        {

        }

        public Persoana(string nume, int varsta, bool angajat)
        {
            this.nume=nume;
            this.varsta=varsta;
            this.angajat=angajat;
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

        public bool Angajat
        {
            get { return this.angajat; }
            set { this.angajat = value; }
        }

        public override string ToString()
        {
            string text = "";

            text+="Nume:"+this.nume+", ";
            text+="Varsta:"+this.varsta+", ";
            text+="Angajat:"+this.angajat;

            return text;
        }

        public int CompareTo(Persoana? other)
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

        public override bool Equals(object? obj)
        {
            Persoana p = obj as Persoana;

            return p.varsta.Equals(this.varsta);
        }

    }
}
