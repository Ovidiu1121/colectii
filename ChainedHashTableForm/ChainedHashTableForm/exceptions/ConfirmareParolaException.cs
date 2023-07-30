using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.exceptions
{
    public class ConfirmareParolaException  :Exception
    {

        public ConfirmareParolaException() { }

        public ConfirmareParolaException(string message) : base(message) { }

        public ConfirmareParolaException(string message, Exception innerException) : base(message, innerException) { }

    }
}
