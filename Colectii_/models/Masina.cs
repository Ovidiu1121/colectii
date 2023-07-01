using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.models
{
    public class Masina : IComparable<Masina>
    {
        private string marca;
        private string culoare;
        private int vechime;

        public Masina()
        {

        }

        public Masina(string marca, string culoare, int vechime)
        {
            this.marca = marca;
            this.culoare = culoare;
            this.vechime = vechime;
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Culoare
        {
            get { return this.culoare; }
            set { this.culoare = value; }
        }

        public int Vechime
        {
            get { return this.vechime; }
            set { this.vechime = value; }
        }

        public int CompareTo(Masina? other)
        {

            if (this.vechime>other.vechime)
            {
                return 1;
            }
            else if (this.vechime==other.vechime)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }

        public override string ToString()
        {
            string text = "";

            text+="Marca:"+this.marca+", ";
            text+="Culoare:"+this.culoare+", ";
            text+="An productie:"+this.vechime;

            return text;
        }

        public override bool Equals(object? obj)
        {
            Masina m = obj as Masina;

            return m.vechime.Equals(this.vechime);

        }

    }
}
