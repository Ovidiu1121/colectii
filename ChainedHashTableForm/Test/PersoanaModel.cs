using Colectii.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    public class PersoanaModel
    {
        [Fact]
        public void createPersoana()
        {
            Persoana p = Persoana.buid()
                .setId(1)
                .setpassword("parolaaa")
                .setVarsta(23)
                .setNume("nuyme")
                .setTip(1);

            Assert.NotNull(p);  

        }


    }
}
