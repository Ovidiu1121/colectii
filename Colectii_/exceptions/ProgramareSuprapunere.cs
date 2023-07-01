using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.exceptions
{
    public class ProgramareSuprapunere : Exception
    {
        public ProgramareSuprapunere() { }

        public ProgramareSuprapunere(string message) : base(message) { }

        public ProgramareSuprapunere(string message, Exception innerException) : base(message, innerException) { }

    }

}
