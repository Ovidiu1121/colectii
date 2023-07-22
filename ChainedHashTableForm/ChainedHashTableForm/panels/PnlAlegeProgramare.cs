using ChainedHashTableForm.forms;
using Colectii;
using Colectii.colectii.impl;
using Colectii.models;
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
    public class PnlAlegeProgramare:Panel
    {
        private Button btngomain;
        private DataGridView grid;
        private Label lbltitlu;
        private Persoana persoana;
        private FrmMain frmMain;
        private ControlerChainedHashTable controler;
        private Programare programare;
        private Button btnmodifica;

        public PnlAlegeProgramare(FrmMain frmMain,Persoana persoana, ControlerChainedHashTable controler)
        {

            this.frmMain = frmMain;
            this.persoana = persoana;
            this.controler = controler;

            this.Size = new Size(741, 403);

            this.grid = new DataGridView();
            this.Controls.Add(grid);
            this.grid.Location=new Point(100, 100);
            this.grid.Size = new Size(500, 100);
            this.grid.CellClick+=new DataGridViewCellEventHandler(cell_Click);

            this.btngomain = new Button();
            this.Controls.Add(this.btngomain);
            this.btngomain.Location=new Point(500, 300);
            this.btngomain.Size=new Size(114, 23);
            this.btngomain.Text="go back";
            this.btngomain.Click+=new EventHandler(goback_Click);

            this.lbltitlu = new Label();
            this.Controls.Add(this.lbltitlu);
            this.lbltitlu.Location=new Point(45, 32);
            this.lbltitlu.Size=new Size(588, 32);
            this.lbltitlu.Text="Alege o programare";
            this.lbltitlu.Font=new Font("Arial", 16, FontStyle.Regular);

            this.btnmodifica = new Button();
            this.Controls.Add(this.btnmodifica);
            this.btnmodifica.Location=new Point(253, 250);
            this.btnmodifica.Size=new Size(167, 66);
            this.btnmodifica.Text="Modifica programare";
            this.btnmodifica.Font=new Font("Arial", 14, FontStyle.Regular);
            this.btnmodifica.Visible=false;
            this.btnmodifica.Click+=new EventHandler(modifica_Click);

            populate();
        }

        public void goback_Click(object sender, EventArgs e)
        {

            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlMain(this.frmMain, this.persoana, this.controler);
            this.frmMain.Controls.Add(this.frmMain.activepanel);

        }

        public void populate()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("Doctor", typeof(string));
            dt.Columns.Add("Adresa", typeof(string));
            dt.Columns.Add("Data inceput", typeof(DateTime));
            dt.Columns.Add("Data sfarsit", typeof(DateTime));

            ILista<Programare> lista = this.controler.getProgramari(this.persoana);

            Node<Programare> p = lista.getIterator();

            while (p != null)
            {
                dt.Rows.Add(p.Data.NumeDoctor, p.Data.Adresa, p.Data.DataInceput, p.Data.DataSfarsit);
                p=p.Next;
            }

            grid.DataSource = dt;

        }

        public void cell_Click(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex<0) { return; }

            DateTime dataInceput = DateTime.Parse(this.grid.Rows[e.RowIndex].Cells[2].Value.ToString());

            this.programare=this.controler.getProgramare(this.persoana, dataInceput);
            this.btnmodifica.Visible=true;

        }

        public void modifica_Click(object sender,EventArgs e)
        {

            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlModificaProgramare(this.frmMain, this.persoana, this.controler,this.programare);
            this.frmMain.Controls.Add(this.frmMain.activepanel);

        }

    }
}
