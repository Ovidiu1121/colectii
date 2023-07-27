using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.exceptions
{
    public class ProgramareInPauza:Exception
    {
        public ProgramareInPauza() { }

        public ProgramareInPauza(string message) : base(message) { }

        public ProgramareInPauza(string message, Exception innerException) : base(message, innerException) { }

    }
}
