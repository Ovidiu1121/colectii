using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.exceptions
{
    public class ConfirmareParola:Exception
    {

        public ConfirmareParola() { }

        public ConfirmareParola(string message) : base(message) { }

        public ConfirmareParola(string message, Exception innerException) : base(message, innerException) { }

    }
}
