using ChainedHashTableForm.forms;
using Colectii.models;
using Colectii.utils;
using Colectii_.examples;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainedHashTableForm.panels
{
    public class PnlRegister:Panel
    {
        private Persoana persoana;
        private ControlerChainedHashTable controler;
        private Label lbltitle;
        private Label lblnume;
        private Label lblvarsta;
        private Label lblparola;
        private Label lblconfirmare;
        private TextBox txtvarsta;
        private TextBox txtnume;
        private TextBox txtparola;
        private TextBox txtconfirmare;
        private Button btnregister;
        private Button btnanulare;
        private FrmHome frmHome;
        private Label lbltip;
        private TextBox txttip;

        public PnlRegister(FrmHome frmHome,ControlerChainedHashTable controler)
        {
            this.controler = controler;
            this.frmHome = frmHome;

            this.Size = new System.Drawing.Size(741, 403);

            this.lbltitle=new Label();
            this.Controls.Add(this.lbltitle);
            this.lbltitle.Location=new System.Drawing.Point(247, 41);
            this.lbltitle.Size=new System.Drawing.Size(272, 42);
            this.lbltitle.Text="Create account";
            this.lbltitle.Font=new Font("Arial", 22, FontStyle.Regular);

            this.lblnume=new Label();
            this.Controls.Add(this.lblnume);
            this.lblnume.Location=new System.Drawing.Point(141, 98);
            this.lblnume.Size=new System.Drawing.Size(64, 25);
            this.lblnume.Text="Nume";
            this.lblnume.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblvarsta=new Label();
            this.Controls.Add(this.lblvarsta);
            this.lblvarsta.Location=new System.Drawing.Point(141, 149);
            this.lblvarsta.Size=new System.Drawing.Size(69, 25);
            this.lblvarsta.Text="Varsta";
            this.lblvarsta.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblparola=new Label();
            this.Controls.Add(this.lblparola);
            this.lblparola.Location=new System.Drawing.Point(141, 204);
            this.lblparola.Size=new System.Drawing.Size(69, 25);
            this.lblparola.Text="Parola";
            this.lblparola.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblconfirmare=new Label();
            this.Controls.Add(this.lblconfirmare);
            this.lblconfirmare.Location=new System.Drawing.Point(141, 255);
            this.lblconfirmare.Size=new System.Drawing.Size(167, 25);
            this.lblconfirmare.Text="Confirmare parola";
            this.lblconfirmare.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lbltip=new Label();
            this.Controls.Add(this.lbltip);
            this.lbltip.Location=new System.Drawing.Point(141, 309);
            this.lbltip.Size=new System.Drawing.Size(69, 25);
            this.lbltip.Text="Tip";
            this.lbltip.Font=new Font("Arial", 12, FontStyle.Regular);

            this.txtnume=new TextBox();
            this.Controls.Add(this.txtnume);
            this.txtnume.Location=new System.Drawing.Point(314, 98);
            this.txtnume.Size=new Size(281, 22);

            this.txtvarsta=new TextBox();
            this.Controls.Add(this.txtvarsta);
            this.txtvarsta.Location=new System.Drawing.Point(314, 149);
            this.txtvarsta.Size=new Size(281, 22);

            this.txtparola=new TextBox();
            this.Controls.Add(this.txtparola);
            this.txtparola.Location=new System.Drawing.Point(314, 204);
            this.txtparola.Size=new Size(281, 22);
            this.txtparola.UseSystemPasswordChar=true;

            this.txtconfirmare=new TextBox();
            this.Controls.Add(this.txtconfirmare);
            this.txtconfirmare.Location=new System.Drawing.Point(314, 259);
            this.txtconfirmare.Size=new Size(281, 22);
            this.txtconfirmare.UseSystemPasswordChar=true;

            this.txttip=new TextBox();
            this.Controls.Add(this.txttip);
            this.txttip.Location=new System.Drawing.Point(314, 309);
            this.txttip.Size=new Size(281, 22);

            this.btnregister=new Button();
            this.Controls.Add(this.btnregister);
            this.btnregister.Location=new System.Drawing.Point(314, 328);
            this.btnregister.Size=new Size(170, 34);
            this.btnregister.Text="Inregistrare";
            this.btnregister.Font=new Font("Arial", 10, FontStyle.Regular);
            this.btnregister.Click+=new EventHandler(inregistrare_Click);

            this.btnanulare=new Button();
            this.Controls.Add(this.btnanulare);
            this.btnanulare.Location=new System.Drawing.Point(490, 328);
            this.btnanulare.Size=new Size(105, 34);
            this.btnanulare.Text="Anulare";
            this.btnanulare.Font=new Font("Arial", 10, FontStyle.Regular);
            this.btnanulare.Click+=new EventHandler(anulare_Click);

        }


        public void inregistrare_Click(object sender,EventArgs e)
        {

            if(this.txtconfirmare.Text.Equals("")||this.txttip.Text.Equals("")||this.txtnume.Text.Equals("")||this.txtparola.Text.Equals("")||this.txtvarsta.Text.Equals(""))
            {
                MessageBox.Show(Constants.SPATIU_NECOMPLETAT);
            }
            else if (this.controler.isPersoana(this.txtnume.Text, this.txtparola.Text)==true)
            {
                MessageBox.Show(Constants.PERSOANA_EXISTENTA);
            }
            else
            {
                if (this.txtparola.Text.Equals("")==false&&this.txtconfirmare.Text.Equals("")==false)
                {
                    if (this.txtconfirmare.Text.Equals(this.txtparola.Text)==false)
                    {
                        MessageBox.Show(Constants.PAROLA_GRESITA);
                        return;
                    }
                }

                Persoana p = new Persoana(this.txtnume.Text, int.Parse(this.txtvarsta.Text), this.txtparola.Text,int.Parse(this.txttip.Text));

                this.controler.adaugarePersoana(p);

                this.frmHome.Controls.Remove(this.frmHome.activepanel);
                this.frmHome.activepanel=new PnlLogIn(this.frmHome);
                this.frmHome.Controls.Add(this.frmHome.activepanel);
            }

        }

        public void anulare_Click(object sender, EventArgs e)
        {

            this.frmHome.Controls.Remove(this.frmHome.activepanel);
            this.frmHome.activepanel=new PnlLogIn(this.frmHome);
            this.frmHome.Controls.Add(this.frmHome.activepanel);

        }

    }
}
