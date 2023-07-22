using ChainedHashTableForm.forms;
using Colectii.models;
using Colectii_.colectii.hashtable;
using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainedHashTableForm.panels
{
    public class PnlMain:Panel
    {

        private Label lbltitlu;
        private Button btndelete;
        private Button btnadd;
        private Button btnedit;
        private Button btnshow;
        private Persoana persoana;
        private FrmMain frmMain;
        ControlerChainedHashTable controler;
        public PnlMain(FrmMain frmMaim,Persoana persoana,ControlerChainedHashTable controler)
        {
            this.frmMain = frmMaim;
            this.persoana = persoana;
            this.controler = controler;
            this.Size = new System.Drawing.Size(741, 403);

            this.lbltitlu = new Label();
            this.Controls.Add(this.lbltitlu);
            this.lbltitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbltitlu.Location = new System.Drawing.Point(42, 38);
            this.lbltitlu.Size = new System.Drawing.Size(200, 32);
            this.lbltitlu.Text = "Bine ai venit "+persoana.Nume.ToString()+" !";

            this.btnshow=new Button();
            this.Controls.Add(this.btnshow);
            this.btnshow.Location = new System.Drawing.Point(143, 121);
            this.btnshow.Size = new System.Drawing.Size(163, 50);
            this.btnshow.Text = "Vezi programari";
            this.btnshow.Click+=new EventHandler(afisareProgramari_Click);

            this.btnadd=new Button();
            this.Controls.Add(this.btnadd);
            this.btnadd.Location = new System.Drawing.Point(388, 121);
            this.btnadd.Size = new System.Drawing.Size(163, 50);
            this.btnadd.Text = "Adauga programare";
            this.btnadd.Click+=new EventHandler(adaugareProgramare_Click);

            this.btnedit=new Button();
            this.Controls.Add(this.btnedit);
            this.btnedit.Location = new System.Drawing.Point(143, 198);
            this.btnedit.Size = new System.Drawing.Size(163, 50);
            this.btnedit.Text = "Modifica programare";
            this.btnedit.Click+=new EventHandler(modificaProgramare_Click);

            this.btndelete=new Button();
            this.Controls.Add(this.btndelete);
            this.btndelete.Location = new System.Drawing.Point(388, 198);
            this.btndelete.Size = new System.Drawing.Size(163, 50);
            this.btndelete.Text = "Sterge programare";
            this.btndelete.Click+=new EventHandler(stergeProgramare_Click);

        }



        public void afisareProgramari_Click(object sender, EventArgs e)
        {
            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlAfisareProgramari(this.frmMain,this.persoana,this.controler);
            this.frmMain.Controls.Add(this.frmMain.activepanel);

        }

        public void adaugareProgramare_Click(object sender, EventArgs e)
        {
            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlAdaugaProgramare(this.frmMain, this.persoana,this.controler);
            this.frmMain.Controls.Add(this.frmMain.activepanel);
        }

        public void stergeProgramare_Click(object sender, EventArgs e)
        {
            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlStergeProgramare(this.frmMain, this.persoana, this.controler);
            this.frmMain.Controls.Add(this.frmMain.activepanel);
        }

        public void modificaProgramare_Click(object sender, EventArgs e)
        {
            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlAlegeProgramare(this.frmMain, this.persoana, this.controler);
            this.frmMain.Controls.Add(this.frmMain.activepanel);
        }

    }
}
