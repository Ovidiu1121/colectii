using ChainedHashTableForm.colectii.arbori;
using Colectii.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    public class Arbori
    {
        private Ierarhie<Persoana> ierarhie;

        [Fact]

        public void find()
        {

            Persoana p1 = new Persoana("deputy director", 45,"parola1",0);
            Persoana p2 = new Persoana("it division", 29, "parola2",1);
            Persoana p3 = new Persoana("marketing", 23, "parola3", 1);
            Persoana p4 = new Persoana("security", 42, "parola4", 1);
            Persoana p5 = new Persoana("app development", 42, "parola5", 1);
            Persoana p6 = new Persoana("logistics", 42, "parola6", 1);
            Persoana p7 = new Persoana("public relations", 42, "parola7", 1);

            this.ierarhie=new Ierarhie<Persoana>(p1);

            this.ierarhie.add(p1, p2);
            this.ierarhie.add(p1, p3);
            this.ierarhie.add(p2 , p4);
            this.ierarhie.add(p2, p5);
            this.ierarhie.add(p3 , p6);
            this.ierarhie.add(p3, p7);
            
            TreeNode<Persoana> nodulCautat = this.ierarhie.findByData(p7);

            Assert.Equal(nodulCautat.Data, p7);
       
        }

        [Fact]

        public void afisare()
        {
            Persoana p1 = new Persoana("deputy director", 45, "parola1", 0);
            Persoana p2 = new Persoana("it division", 29, "parola2", 1);
            Persoana p3 = new Persoana("marketing", 23, "parola3", 1);
            Persoana p4 = new Persoana("security", 42, "parola4", 1);
            Persoana p5 = new Persoana("app development", 42, "parola5", 1);
            Persoana p6 = new Persoana("logistics", 42, "parola6", 1);
            Persoana p7 = new Persoana("public relations", 42, "parola7", 1);

            this.ierarhie=new Ierarhie<Persoana>(p1);

            this.ierarhie.add(p1, p2);
            this.ierarhie.add(p1, p3);
            this.ierarhie.add(p2, p4);
            this.ierarhie.add(p2, p5);
            this.ierarhie.add(p3, p6);
            this.ierarhie.add(p3, p7);

            //se face cu debug

            this.ierarhie.afisare();

            

        }

    }
}
