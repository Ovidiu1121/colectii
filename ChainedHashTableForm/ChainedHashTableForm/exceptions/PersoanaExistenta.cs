using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.exceptions
{
    public class PersoanaExistenta:Exception
    {
        public PersoanaExistenta() { }

        public PersoanaExistenta(string message) : base(message) { }

        public PersoanaExistenta(string message, Exception innerException) : base(message, innerException) { }

    }
}
