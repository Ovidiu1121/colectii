using ChainedHashTableForm.panels;
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
    public partial class FrmHome : Form
    {
        public Panel activepanel;
        public ControlerChainedHashTable controler;

        public FrmHome()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(750, 403);

            this.controler=new ControlerChainedHashTable();

            this.activepanel=new PnlLogIn(this);

            this.Controls.Add(activepanel);


        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
