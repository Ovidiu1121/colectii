using ChainedHashTableForm.forms;
using Colectii;
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

            Persoana p = new Persoana("alex", 13, false);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmHome());

            ControlerChainedHashTable a = new ControlerChainedHashTable();

            Programare p2 = new Programare("Dct 2", "alex", "asdffgjasf", new DateTime(2050, 10, 2), new DateTime(2050, 10, 6));

            Programare p1 = new Programare("Dct 1", "mihai", "adr1", new DateTime(2020, 3, 23), new DateTime(2020, 3, 20));

            a.update(p1, p2);
            a.load();

            Debug.WriteLine(p1.ToString());

        }
    }
}
