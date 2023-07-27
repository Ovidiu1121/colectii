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
        private FrmMain frmMain;
        private ControlerChainedHashTable controler;
        private Persoana persoana;
        private Button btngomain;
        private Panel panel;

        public PnlAfisareProgramari(FrmMain frmMain, Persoana persoana,ControlerChainedHashTable controler)
        {
            this.frmMain = frmMain;
            this.persoana = persoana;
            this.controler = controler;

            this.Size = new Size(741, 403);

            this.panel=new Panel();
            this.Controls.Add(this.panel);
            this.panel.Location = new Point(66, 36);
            this.panel.Size = new Size(580, 260);
            //this.panel.BorderStyle=BorderStyle.Fixed3D;

            this.btngomain = new Button();
            this.Controls.Add(this.btngomain);
            this.btngomain.Location=new Point(500,300);
            this.btngomain.Size=new Size(114, 23);
            this.btngomain.Text="go back";
            this.btngomain.Click+=new EventHandler(goback_Click);

            if (persoana.Tip==1)
            {
                createDoctorCards(4);
            }
            else
            {
                createClientCards(4);
            }

            

        }

        public void goback_Click(object sender,EventArgs e)
        {

            this.frmMain.Controls.Remove(this.frmMain.activepanel);
            this.frmMain.activepanel=new PnlMain(this.frmMain, this.persoana,this.controler);
            this.frmMain.Controls.Add(this.frmMain.activepanel);

        }

        public void createDoctorCards(int nrColumns)
        {

            ILista<Programare> lista = this.controler.getProgramariByClientId(this.persoana.Id);

            Node<Programare> p = lista.getIterator();

            int x = 20, y = 20, contor = 0;

            while(p != null)
            {
                Panel pnl = new PnlCardDoctor(p.Data.Id,this.controler.getNume(p.Data.Id), p.Data.Adresa, p.Data.DataInceput, p.Data.DataSfarsit);

                pnl.Location = new Point(x,y);
                pnl.Size = new Size(120, 150);
                this.panel.Controls.Add(pnl);
                contor++;

                x+=130;

                if (contor%nrColumns==0)
                {
                    x=20;
                    y+=160;
                }
                
                if (y>this.panel.Height)
                {
                    this.panel.AutoScroll = true;
                }
                p=p.Next;
            }
        }

        public void createClientCards(int nrColumns)
        {

            ILista<Programare> lista = this.controler.getProgramariByClientId(this.persoana.Id);

            Node<Programare> p = lista.getIterator();

            int x = 20, y = 20, contor = 0;

            while (p != null)
            {
                Panel pnl = new PnlCardClient( p.Data.Id, p.Data.Adresa, p.Data.DataInceput, p.Data.DataSfarsit);

                pnl.Location = new Point(x, y);
                pnl.Size = new Size(110, 150);
                this.panel.Controls.Add(pnl);
                contor++;

                x+=130;

                if (contor%nrColumns==0)
                {
                    x=20;
                    y+=160;
                }

                if (y>this.panel.Height)
                {
                    this.panel.AutoScroll = true;
                }
                p=p.Next;
            }

        }

    }
}
