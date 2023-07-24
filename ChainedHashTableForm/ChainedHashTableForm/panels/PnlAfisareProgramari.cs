using ChainedHashTableForm.forms;
using Colectii;
using Colectii.colectii.impl;
using Colectii.models;
using Colectii_.colectii.hashtable;
using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainedHashTableForm.panels
{
    public class PnlAfisareProgramari:Panel
    {
        private DataGridView grid;
        private FrmMain frmMain;
        private ControlerChainedHashTable controler;
        private Persoana persoana;
        private Button btngomain;

        public PnlAfisareProgramari(FrmMain frmMain, Persoana persoana,ControlerChainedHashTable controler)
        {
            this.frmMain = frmMain;
            this.persoana = persoana;
            this.controler = controler;

            this.Size = new Size(741, 403);

            this.grid = new DataGridView();
            this.Controls.Add(grid);
            this.grid.Location=new Point(100, 100);
            this.grid.Size = new Size(500, 100);

            this.btngomain = new Button();
            this.Controls.Add(this.btngomain);
            this.btngomain.Location=new Point(500,300);
            this.btngomain.Size=new Size(114, 23);
            this.btngomain.Text="go back";
            this.btngomain.Click+=new EventHandler(goback_Click);

            populate();

            

        }

        public void goback_Click(object sender,EventArgs e)
        {

            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlMain(this.frmMain, this.persoana,this.controler);
            this.frmMain.Controls.Add(this.frmMain.activepanel);

        }

        public void populate()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Adresa", typeof(string));
            dt.Columns.Add("Data inceput", typeof(DateTime));
            dt.Columns.Add("Data sfarsit", typeof(DateTime));

            ILista<Programare> lista = this.controler.getProgramariByClientId(this.persoana.Id);

            Node<Programare> p = lista.getIterator();

            while(p != null)
            {
                dt.Rows.Add(p.Data.Id,p.Data.Adresa,p.Data.DataInceput,p.Data.DataSfarsit);
                p=p.Next;
            }

            grid.DataSource = dt;

        }

    }
}
