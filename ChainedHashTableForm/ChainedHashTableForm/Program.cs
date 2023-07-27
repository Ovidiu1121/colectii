using ChainedHashTableForm.forms;
using Colectii;
using Colectii.colectii.impl;
using Colectii.models;
using Colectii_.colectii.hashtable;
using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainedHashTableForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Persoana p = new Persoana("alex", 13,"affs",1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmHome());

            //ControlerChainedHashTable a = new ControlerChainedHashTable();

            //Persoana b = new Persoana("casian", 13, "dsafas");

            //Programare pr=new Programare(22,"adr33",new DateTime(2000,2,3),new DateTime(2000,2,5));

            //Programare pr2 = new Programare(1, "adr1", new DateTime(2013, 10, 2), new DateTime(2013,10,8));

            //a.update(pr2,pr);


        }
    }
}
