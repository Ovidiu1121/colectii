using ChainedHashTableForm.forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainedHashTableForm.panels
{
    public class PnlCardDoctor:Panel
    {
        private Label lblid;
        private Label lbladresa;
        private Label lbldatainceput;
        private Label lbldatasfarsit;
        private Label lblnume;

        public PnlCardDoctor(int id,string nume, string adresa, DateTime datainceput, DateTime datasfarsit)
        {

            this.BorderStyle=BorderStyle.FixedSingle;

            this.lblid = new Label();
            this.Controls.Add(this.lblid);
            this.lblid.Location = new System.Drawing.Point(32, 5);
            this.lblid.Size = new System.Drawing.Size(60, 22);
            this.lblid.Text="Id: "+id.ToString();
            this.lblid.Font=new Font("Arial", 12, FontStyle.Bold);

            this.lblnume = new Label();
            this.Controls.Add(this.lblnume);
            this.lblnume.Location = new System.Drawing.Point(10, 25);
            this.lblnume.Size = new System.Drawing.Size(103, 40);
            this.lblnume.Text="Nume client:\n"+adresa.ToString();
            this.lblnume.Font=new Font("Arial", 10, FontStyle.Italic);

            this.lbladresa = new Label();
            this.Controls.Add(this.lbladresa);
            this.lbladresa.Location = new System.Drawing.Point(10, 62);
            this.lbladresa.Size = new System.Drawing.Size(108, 40);
            this.lbladresa.Text="Adresa:\n"+adresa.ToString();
            this.lbladresa.Font=new Font("Arial", 10, FontStyle.Italic);

            this.lbldatainceput = new Label();
            this.Controls.Add(this.lbldatainceput);
            this.lbldatainceput.Location = new System.Drawing.Point(10, 100);
            this.lbldatainceput.Size = new System.Drawing.Size(109, 40);
            this.lbldatainceput.Text="Data inceput:\n"+datainceput.ToString();
            this.lbldatainceput.Font=new Font("Arial", 10, FontStyle.Italic);

            this.lbldatasfarsit = new Label();
            this.Controls.Add(this.lbldatasfarsit);
            this.lbldatasfarsit.Location = new System.Drawing.Point(10, 140);
            this.lbldatasfarsit.Size = new System.Drawing.Size(102, 40);
            this.lbldatasfarsit.Text="Data sfarsit:\n"+datasfarsit.ToString();
            this.lbldatasfarsit.Font=new Font("Arial", 10, FontStyle.Italic);

            this.AutoScroll = true;

        }

    }
}
