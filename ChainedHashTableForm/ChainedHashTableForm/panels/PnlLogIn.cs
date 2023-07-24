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
    public class PnlLogIn : Panel
    {
        private Label lbltitlu;
        private Label lblnume;
        private Label lblpassword;
        private TextBox txtpassword;
        private TextBox txtnume;
        private Button btnlogin;
        private FrmHome frmHome;
        private ControlerChainedHashTable controler = new ControlerChainedHashTable();
        private Button btnregister;
        public PnlLogIn(FrmHome frmHome)
        {

            this.frmHome = frmHome;
            this.Size=new Size(611, 366);


            this.lbltitlu = new Label();
            this.Controls.Add(lbltitlu);
            this.lbltitlu.Location=new Point(225, 22);
            this.lbltitlu.Size=new Size(116, 39);
            this.lbltitlu.Text="Log in";
            this.lbltitlu.Font=new Font("Arial", 20, FontStyle.Bold);

            this.lblnume = new Label();
            this.Controls.Add(lblnume);
            this.lblnume.Location=new Point(99, 117);
            this.lblnume.Size=new Size(70, 16);
            this.lblnume.Text="Nume";
            this.lblnume.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblpassword = new Label();
            this.Controls.Add(lblpassword);
            this.lblpassword.Location=new Point(99, 167);
            this.lblpassword.Size=new Size(70, 16);
            this.lblpassword.Text="Parola";
            this.lblpassword.Font=new Font("Arial", 12, FontStyle.Regular);

            this.txtnume=new TextBox();
            this.Controls.Add(this.txtnume);
            this.txtnume.Location = new Point(170, 117);
            this.txtnume.Size = new Size(288, 22);

            this.txtpassword=new TextBox();
            this.Controls.Add(this.txtpassword);
            this.txtpassword.Location = new Point(170, 161);
            this.txtpassword.Size = new Size(288, 22);

            this.btnlogin=new Button();
            this.Controls.Add(this.btnlogin);
            this.btnlogin.Location=new Point(238, 219);
            this.btnlogin.Size=new Size(103, 30);
            this.btnlogin.Text="Log in";
            this.btnlogin.Click+=new EventHandler(logare_Click);

            this.btnregister=new Button();
            this.Controls.Add(this.btnregister);
            this.btnregister.Location=new Point(238, 250);
            this.btnregister.Size=new Size(103, 30);
            this.btnregister.Text="Register";
            this.btnregister.Click+=new EventHandler(register_Click);

        }

        public void logare_Click(object sender, EventArgs e)
        {

            if (this.txtpassword.Text.Equals("")||this.txtnume.Text.Equals(""))
            {
                throw new EmptyField(Constants.SPATIU_NECOMPLETAT);
            }
            else
            {
                if(this.controler.isPersoana(this.txtnume.Text, this.txtpassword.Text)==false)
                {
                    MessageBox.Show(Constants.WRONG_PERSON);
                }
                else
                {
                    Persoana p = this.controler.getPersoana(this.txtpassword.Text);

                    FrmMain main = new FrmMain(p);
                    frmHome.Hide();
                    main.Closed+=(s, args) => this.frmHome.Close();
                    main.Show();
                }
                
                
            }


        }

        public void register_Click(object sender, EventArgs e)
        {

            this.frmHome.Controls.Remove(this.frmHome.activepanel);
            this.frmHome.activepanel=new PnlRegister(this.frmHome,this.controler);
            this.frmHome.Controls.Add(this.frmHome.activepanel);

        }

    }
}
