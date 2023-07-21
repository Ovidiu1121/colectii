using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedHashTableForm.exceptions
{
    public class WrongPerson : Exception
    {
        public WrongPerson() { }

        public WrongPerson(string message) : base(message) { }

        public WrongPerson(string message, Exception innerException) : base(message, innerException) { }


    }
}
