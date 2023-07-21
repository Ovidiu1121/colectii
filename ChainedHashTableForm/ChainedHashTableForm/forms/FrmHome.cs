using ChainedHashTableForm.panels;
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
        private Panel activepanel;

        public FrmHome()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(1000, 403);

            this.activepanel=new PnlLogIn(this);

            this.Controls.Add(activepanel);


        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
