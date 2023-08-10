using Colectii.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.interfaces
{
    public interface IPersoanaBuilder
    {
        Persoana setId(int id);
        Persoana setNume(string nume);
        Persoana setVarsta(int varsta);
        Persoana setpassword(string password);
        Persoana setTip(int tip);

    }
}
