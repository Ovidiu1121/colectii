using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.interfaces
{
    public interface IProgramareBuilder
    {
        Programare setId(int id);
        Programare setIdClient(int idClient);
        Programare setAdresa(string adresa);
        Programare setDataInceput(DateTime dataInceput);
        Programare setDataSfarsit(DateTime dataSfarsit);


    }
}
