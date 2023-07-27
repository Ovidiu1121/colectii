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
    public class PnlCardClient:Panel
    {
        private Label lblid;
        private Label lbladresa;
        private Label lbldatainceput;
        private Label lbldatasfarsit;

        public PnlCardClient(int id, string adresa,DateTime datainceput,DateTime datasfarsit)
        {
            this.BorderStyle=BorderStyle.FixedSingle;


            this.lblid = new Label();
            this.Controls.Add(this.lblid);
            this.lblid.Location = new System.Drawing.Point(32, 5);
            this.lblid.Size = new System.Drawing.Size(60, 22);
            this.lblid.Text="Id: "+id.ToString();
            this.lblid.Font=new Font("Arial", 12, FontStyle.Bold);

            this.lbladresa = new Label();
            this.Controls.Add(this.lbladresa);
            this.lbladresa.Location = new System.Drawing.Point(10, 33);
            this.lbladresa.Size = new System.Drawing.Size(108, 40);
            this.lbladresa.Text="Adresa:\n"+adresa.ToString();
            this.lbladresa.Font=new Font("Arial", 10, FontStyle.Italic);

            this.lbldatainceput = new Label();
            this.Controls.Add(this.lbldatainceput);
            this.lbldatainceput.Location = new System.Drawing.Point(10, 73);
            this.lbldatainceput.Size = new System.Drawing.Size(109, 40);
            this.lbldatainceput.Text="Data inceput:\n"+datainceput.ToString();
            this.lbldatainceput.Font=new Font("Arial", 10, FontStyle.Italic);
             
            this.lbldatasfarsit = new Label();
            this.Controls.Add(this.lbldatasfarsit);
            this.lbldatasfarsit.Location = new System.Drawing.Point(10, 113);
            this.lbldatasfarsit.Size = new System.Drawing.Size(102, 40);
            this.lbldatasfarsit.Text="Data sfarsit:\n"+datasfarsit.ToString();
            this.lbldatasfarsit.Font=new Font("Arial", 10, FontStyle.Italic);

        }


    }
}
