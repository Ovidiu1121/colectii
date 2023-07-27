using ChainedHashTableForm.exceptions;
using ChainedHashTableForm.forms;
using Colectii.models;
using Colectii.utils;
using Colectii_.colectii.hashtable;
using Colectii_.examples;
using Colectii_.exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainedHashTableForm.panels
{
    public class PnlAdaugaProgramare:Panel
    {

        private FrmMain frmMain;
        private Persoana persoana;
        private Label lbltitlu;
        private Label lbldoctor;
        private Label lbladresa;
        private Label lbldatainceput;
        private Label lbldatasfarsit;
        private TextBox txtdoctor;
        private TextBox txtadresa;
        private DateTimePicker datainceput;
        private DateTimePicker datasfarsit;
        private Button btnadd;
        private Button btngomain;
        private ControlerChainedHashTable controler;

        public PnlAdaugaProgramare(FrmMain frmMain,Persoana persoana,ControlerChainedHashTable controler)
        {
            this.frmMain = frmMain;
            this.persoana = persoana;
            this.controler = controler;
            this.Size = new System.Drawing.Size(741, 403);

            this.lbltitlu = new Label();
            this.Controls.Add(this.lbltitlu);
            this.lbltitlu.Location = new Point(170, 22);
            this.lbltitlu.Size=new Size(448, 52);
            this.lbltitlu.Text = "Adauga programare";
            this.lbltitlu.Font=new Font("Arial", 26, FontStyle.Regular);

            this.lbladresa = new Label();
            this.Controls.Add(this.lbladresa);
            this.lbladresa.Location = new Point(184, 187);
            this.lbladresa.Size=new Size(105, 20);
            this.lbladresa.Text = "Adresa";
            this.lbladresa.Font=new Font("Arial", 10, FontStyle.Regular);

            this.lbldatainceput = new Label();
            this.Controls.Add(this.lbldatainceput);
            this.lbldatainceput.Location = new Point(184, 245);
            this.lbldatainceput.Size=new Size(105, 20);
            this.lbldatainceput.Text = "Data inceput";
            this.lbldatainceput.Font=new Font("Arial", 10, FontStyle.Regular);

            this.lbldatasfarsit = new Label();
            this.Controls.Add(this.lbldatasfarsit);
            this.lbldatasfarsit.Location = new Point(184, 302);
            this.lbldatasfarsit.Size=new Size(105, 20);
            this.lbldatasfarsit.Text = "Data sfarsit";
            this.lbldatasfarsit.Font=new Font("Arial", 10, FontStyle.Regular);

            this.txtadresa=new TextBox();
            this.Controls.Add(this.txtadresa);
            this.txtadresa.Location=new Point(318, 187);
            this.txtadresa.Size=new Size(250, 22);

            this.datainceput=new DateTimePicker();
            this.Controls.Add(this.datainceput);
            this.datainceput.Location=new Point(318, 245);
            this.datainceput.Size=new Size(250, 22);

            this.datasfarsit=new DateTimePicker();
            this.Controls.Add(this.datasfarsit);
            this.datasfarsit.Location=new Point(318, 300);
            this.datasfarsit.Size=new Size(250, 22);

            this.btnadd=new Button();
            this.Controls.Add(this.btnadd);
            this.btnadd.Location = new System.Drawing.Point(318, 325);
            this.btnadd.Size = new System.Drawing.Size(115, 29);
            this.btnadd.Text = "Adaugare";
            this.btnadd.Click+=new EventHandler(adaugare_Click);

            this.btngomain = new Button();
            this.Controls.Add(this.btngomain);
            this.btngomain.Location=new Point(450, 325);
            this.btngomain.Size=new Size(115, 29);
            this.btngomain.Text="go back";
            this.btngomain.Click+=new EventHandler(goback_Click);


        }

        public void adaugare_Click(object sender, EventArgs e)
        {

            if (this.txtadresa.Text.Equals("")||this.datainceput.Value>this.datasfarsit.Value)
            {
                MessageBox.Show(Constants.SPATIU_NECOMPLETAT);
            }
            else
            {
                Programare p=new Programare(persoana.Id,this.txtadresa.Text,this.datainceput.Value,this.datasfarsit.Value);

                this.controler=new ControlerChainedHashTable();

                if (this.controler.addProgramareInPauza(this.persoana,p)==true)
                {
                    MessageBox.Show(Constants.PROGRAMARE_IN_PAUZA);
                }
                else
                {
                    this.controler.adaugare(p);
                }
                this.frmMain.Controls.Remove(this.frmMain.activepanel);
                this.frmMain.activepanel=new PnlMain(this.frmMain, this.persoana,this.controler);
                this.frmMain.Controls.Add(this.frmMain.activepanel);

            }

        }

        public void goback_Click(object sender, EventArgs e)
        {

            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlMain(this.frmMain, this.persoana,this.controler);
            this.frmMain.Controls.Add(this.frmMain.activepanel);

        }

    }
}
