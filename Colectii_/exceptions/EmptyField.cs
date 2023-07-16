using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii_.exceptions
{
    public class EmptyField:Exception
    {
        public EmptyField() { }

        public EmptyField(string message) : base(message) { }

        public EmptyField(string message, Exception innerException) : base(message, innerException) { }


    }
}
