using ChainedHashTableForm.forms;
using Colectii.models;
using Colectii.utils;
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
    public class PnlModificaProgramare:Panel
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
        private Button btnupdate;
        private Button btngomain;
        private ControlerChainedHashTable controler;
        private Programare programare;

        public PnlModificaProgramare(FrmMain frmMain,Persoana persoana,ControlerChainedHashTable controler,Programare programare)
        {

            this.frmMain = frmMain;
            this.persoana = persoana;
            this.controler = controler;
            this.programare = programare;

            this.Size = new System.Drawing.Size(741, 403);

            this.lbltitlu = new Label();
            this.Controls.Add(this.lbltitlu);
            this.lbltitlu.Location = new Point(170, 22);
            this.lbltitlu.Size=new Size(448, 52);
            this.lbltitlu.Text = "Modifica Programare";
            this.lbltitlu.Font=new Font("Arial", 26, FontStyle.Regular);

            //this.lbldoctor = new Label();
            //this.Controls.Add(this.lbldoctor);
            //this.lbldoctor.Location = new Point(160, 110);
            //this.lbldoctor.Size=new Size(105, 20);
            //this.lbldoctor.Text = "Nume doctor";
            //this.lbldoctor.Font=new Font("Arial", 10, FontStyle.Regular);

            this.lbladresa = new Label();
            this.Controls.Add(this.lbladresa);
            this.lbladresa.Location = new Point(160, 160);
            this.lbladresa.Size=new Size(105, 20);
            this.lbladresa.Text = "Adresa";
            this.lbladresa.Font=new Font("Arial", 10, FontStyle.Regular);

            this.lbldatainceput = new Label();
            this.Controls.Add(this.lbldatainceput);
            this.lbldatainceput.Location = new Point(160, 220);
            this.lbldatainceput.Size=new Size(105, 20);
            this.lbldatainceput.Text = "Data inceput";
            this.lbldatainceput.Font=new Font("Arial", 10, FontStyle.Regular);

            this.lbldatasfarsit = new Label();
            this.Controls.Add(this.lbldatasfarsit);
            this.lbldatasfarsit.Location = new Point(160, 280);
            this.lbldatasfarsit.Size=new Size(105, 20);
            this.lbldatasfarsit.Text = "Data sfarsit";
            this.lbldatasfarsit.Font=new Font("Arial", 10, FontStyle.Regular);

            //this.txtdoctor=new TextBox();
            //this.Controls.Add(this.txtdoctor);
            //this.txtdoctor.Location=new Point(290, 110);
            //this.txtdoctor.Size=new Size(250, 22);
            //this.txtdoctor.Text=programare.Id.ToString();

            this.txtadresa=new TextBox();
            this.Controls.Add(this.txtadresa);
            this.txtadresa.Location=new Point(290, 160);
            this.txtadresa.Size=new Size(250, 22);
            this.txtadresa.Text=programare.Adresa.ToString();

            this.datainceput=new DateTimePicker();
            this.Controls.Add(this.datainceput);
            this.datainceput.Location=new Point(290, 220);
            this.datainceput.Size=new Size(250, 22);
            this.datainceput.Value=programare.DataInceput;

            this.datasfarsit=new DateTimePicker();
            this.Controls.Add(this.datasfarsit);
            this.datasfarsit.Location=new Point(290, 280);
            this.datasfarsit.Size=new Size(250, 22);
            this.datasfarsit.Value=programare.DataSfarsit;

            this.btnupdate=new Button();
            this.Controls.Add(this.btnupdate);
            this.btnupdate.Location = new System.Drawing.Point(290, 310);
            this.btnupdate.Size = new System.Drawing.Size(115, 29);
            this.btnupdate.Text = "Update";
            this.btnupdate.Click+=new EventHandler(update_Click);

            this.btngomain = new Button();
            this.Controls.Add(this.btngomain);
            this.btngomain.Location=new Point(430, 310);
            this.btngomain.Size=new Size(115, 29);
            this.btngomain.Text="go back";
            this.btngomain.Click+=new EventHandler(goback_Click);

        }

        public void update_Click(object sender, EventArgs e)
        {
            if (this.txtadresa.Text.Equals(""))
            {
                throw new EmptyField(Constants.SPATIU_NECOMPLETAT);
            }
            else
            {
                Programare p = new Programare(this.programare.Id,this.persoana.Id, this.txtadresa.Text,
                    this.programare.DataInceput, this.programare.DataSfarsit);

                this.controler.update(this.programare, p);
                this.frmMain.Controls.Remove(this.frmMain.activepanel);
                this.frmMain.activepanel=new PnlMain(this.frmMain, this.persoana, this.controler);
                this.frmMain.Controls.Add(this.frmMain.activepanel);
            }


        }

        public void goback_Click(object sender, EventArgs e)
        {

            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlMain(this.frmMain, this.persoana, this.controler);
            this.frmMain.Controls.Add(this.frmMain.activepanel);

        }
    }
}
