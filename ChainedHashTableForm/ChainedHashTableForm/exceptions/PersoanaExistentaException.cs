using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.exceptions
{
    public class PersoanaExistentaException : Exception
    {
        public PersoanaExistentaException() { }

        public PersoanaExistentaException(string message) : base(message) { }

        public PersoanaExistentaException(string message, Exception innerException) : base(message, innerException) { }

    }
}
