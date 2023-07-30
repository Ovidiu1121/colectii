using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.exceptions
{
    public class ProgramareInPauzaException : Exception
    {
        public ProgramareInPauzaException() { }

        public ProgramareInPauzaException(string message) : base(message) { }

        public ProgramareInPauzaException(string message, Exception innerException) : base(message, innerException) { }

    }
}
