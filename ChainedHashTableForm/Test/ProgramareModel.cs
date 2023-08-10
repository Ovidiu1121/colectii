using Colectii.models;
using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    public class ProgramareModel
    {
        [Fact]
        public void createProgramare()
        {

            Programare p = Programare.buid()
                .setId(1)
                .setIdClient(1)
                .setAdresa("adresaaa")
                .setDataInceput(new DateTime(2023, 3, 4))
                .setDataSfarsit(new DateTime(2023, 3, 6));

            Assert.NotNull(p);
        }


    }
}
