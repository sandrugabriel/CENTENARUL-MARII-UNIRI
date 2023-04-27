﻿using CENTENARUL_MARII_UNIRI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CENTENARUL_MARII_UNIRI.Panel_uri
{
    internal class pnlItem4:Panel
    {

        Item item;

        Label lblEnunt;
        RichTextBox txtEnunt;
        Button btnRaspund;
        pnleLearning1918_Elev form;
        RadioButton btn2;
        RadioButton btn1;

        public pnlItem4(Item item1, pnleLearning1918_Elev form1)
        {


            item = item1;
            form = form1;

            this.Location = new System.Drawing.Point(48, 93);
            this.Name = "pnlItem4";
            this.Size = new System.Drawing.Size(941, 395);

            this.txtEnunt = new System.Windows.Forms.RichTextBox();
            this.lblEnunt = new System.Windows.Forms.Label();
            this.btnRaspund = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.RadioButton();


            this.Controls.Add(this.lblEnunt);
            this.Controls.Add(this.txtEnunt);
            this.Controls.Add(this.btnRaspund);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);


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

            // btn1
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(89, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(134, 28);
            this.btn1.Text = "Adevarat";

            // btn2
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(89, 253);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(134, 28);
            this.btn2.Text = "Fals";


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
            int raspunsDat = 0;
            if (btn1.Checked)
            {
                raspunsDat = 1;
            }
            else if (btn2.Checked)
            {
                raspunsDat = 0;
            }
           
            if (raspunsDat == item.getraspunsitem4())
            {

                form.punctaj++;

            }
            this.form.lblPunctaj.Text = "Punctaj = " + form.punctaj;
            this.Visible = false;

        }




    }
}
