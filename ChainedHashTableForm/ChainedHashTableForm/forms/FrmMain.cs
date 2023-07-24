using ChainedHashTableForm.panels;
using Colectii.models;
using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainedHashTableForm.forms
{
    public partial class FrmMain : Form
    {
        public Panel activepanel;
        public ControlerChainedHashTable controler;

        public FrmMain(Persoana persoana)
        {
            InitializeComponent();
            this.controler=new ControlerChainedHashTable();

            this.Size = new System.Drawing.Size(741, 403);

            this.activepanel=new PnlMain(this,persoana,controler);

            this.Controls.Add(activepanel);

        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
