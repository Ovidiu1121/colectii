using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.exceptions
{
    public class SuprapunereProgramareException : Exception
    {
        public SuprapunereProgramareException() { }

        public SuprapunereProgramareException(string message) : base(message) { }

        public SuprapunereProgramareException(string message, Exception innerException) : base(message, innerException) { }

    }

}
