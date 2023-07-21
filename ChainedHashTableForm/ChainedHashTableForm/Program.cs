﻿using ChainedHashTableForm.forms;
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(p));

            //ControlerChainedHashTable a = new ControlerChainedHashTable();

            //Programare p2 = a.getProgramare(p, new DateTime(2022, 8, 28));

            //Debug.WriteLine(p2.ToString());

        }
    }
}
