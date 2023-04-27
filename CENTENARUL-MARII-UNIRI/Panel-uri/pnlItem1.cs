using CENTENARUL_MARII_UNIRI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CENTENARUL_MARII_UNIRI.Panel_uri
{
    internal class pnlItem1:Panel
    {

        Item item;


        TextBox txtRaspuns;
        Label lblRaspuns;
        Label lblEnunt;
        RichTextBox txtEnunt;
        Button btnRaspund;

        pnleLearning1918_Elev form;

        public pnlItem1(Item item1, pnleLearning1918_Elev form1)
        {

            item = item1;
            form =form1;

            this.Location = new System.Drawing.Point(48, 93);
            this.Name = "pnlItem1";
            this.Size = new System.Drawing.Size(941, 395);

            this.txtEnunt = new System.Windows.Forms.RichTextBox();
            this.lblEnunt = new System.Windows.Forms.Label();
            this.lblRaspuns = new System.Windows.Forms.Label();
            this.txtRaspuns = new System.Windows.Forms.TextBox();
            this.btnRaspund = new System.Windows.Forms.Button();

            this.Controls.Add(this.lblRaspuns);
            this.Controls.Add(this.lblEnunt);
            this.Controls.Add(this.txtRaspuns);
            this.Controls.Add(this.txtEnunt);
            this.Controls.Add(this.btnRaspund);


            // txtEnunt
            this.txtEnunt.Location = new System.Drawing.Point(272, 52);
            this.txtEnunt.Name = "txtEnunt";
            this.txtEnunt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.txtEnunt.Size = new System.Drawing.Size(454, 126);
            this.txtEnunt.Text = item.getenunt();
             
            // lblEnunt
            this.lblEnunt.AutoSize = true;
            this.lblEnunt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblEnunt.Location = new System.Drawing.Point(83, 93);
            this.lblEnunt.Name = "label1";
            this.lblEnunt.Size = new System.Drawing.Size(94, 36);
            this.lblEnunt.TabIndex = 1;
            this.lblEnunt.Text = "Enunt:";
             
            // lblRaspuns
            this.lblRaspuns.AutoSize = true;
            this.lblRaspuns.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblRaspuns.Location = new System.Drawing.Point(83, 222);
            this.lblRaspuns.Name = "label2";
            this.lblRaspuns.Size = new System.Drawing.Size(127, 36);
            this.lblRaspuns.Text = "Raspuns:";
             
            // txtRapsn
            this.txtRaspuns.Location = new System.Drawing.Point(272, 227);
            this.txtRaspuns.Name = "textBox1";
            this.txtRaspuns.Size = new System.Drawing.Size(454, 31);

            // btnRaspund
            this.btnRaspund.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.btnRaspund.Location = new System.Drawing.Point(791, 338);
            this.btnRaspund.Name = "btnRaspund";
            this.btnRaspund.Size = new System.Drawing.Size(124, 42);
            this.btnRaspund.Text = "Raspund";
            this.btnRaspund.Click += new EventHandler(btnRaspund_Click);

        }

        private void btnRaspund_Click(object sender, EventArgs e)
        {

            if(txtRaspuns.Text.Equals(item.getraspunsitem1()))
            {

                form.punctaj++;

            }
            this.form.lblPunctaj.Text = "Punctaj = " + form.punctaj;
            this.Visible = false;
            
        }









    }
}
