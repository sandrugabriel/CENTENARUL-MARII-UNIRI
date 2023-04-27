using CENTENARUL_MARII_UNIRI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CENTENARUL_MARII_UNIRI.Panel_uri
{
    internal class pnlItem3:Panel
    {

        Item item;

        Label lblEnunt;
        RichTextBox txtEnunt;
        Button btnRaspund;
        pnleLearning1918_Elev form;
        CheckBox btn2;
        CheckBox btn3;
        CheckBox btn4;
        CheckBox btn1; 
        List<int> raspunsuriCorecte;
        public pnlItem3(Item item1, pnleLearning1918_Elev form1)
        {


            item = item1;
            form = form1;

            this.Location = new System.Drawing.Point(48, 93);
            this.Name = "pnlItem3";
            this.Size = new System.Drawing.Size(941, 395);

            this.txtEnunt = new System.Windows.Forms.RichTextBox();
            this.lblEnunt = new System.Windows.Forms.Label();
            this.btnRaspund = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.CheckBox();
            this.btn4 = new System.Windows.Forms.CheckBox();
            this.btn3 = new System.Windows.Forms.CheckBox();
            this.btn2 = new System.Windows.Forms.CheckBox();
            raspunsuriCorecte = new List<int>();
            int n = item.getraspunsitem3();
            while (n != 0)
            {

                int c = n % 10;
                raspunsuriCorecte.Add(c);
                
                n /= 10;
            }

            this.Controls.Add(this.lblEnunt);
            this.Controls.Add(this.txtEnunt);
            this.Controls.Add(this.btnRaspund);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);


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
            this.btn1.Text = item.getvalitem3()[0];

            // btn2
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(89, 253);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(134, 28);
            this.btn2.Text = item.getvalitem3()[1];

            // btn3
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(89, 300);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(134, 28);
            this.btn3.Text = item.getvalitem3()[2];

            // btn4
            this.btn4.AutoSize = true;
            this.btn4.Location = new System.Drawing.Point(89, 347);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(134, 28);
            this.btn4.Text = item.getvalitem3()[3];


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
            List<int> raspunsuriDate = new List<int>();
            if (btn1.Checked)
            {
                raspunsuriDate.Add(1);
            }
            if (btn2.Checked)
            {
                raspunsuriDate.Add(2);
            }
            if (btn3.Checked)
            {
                raspunsuriDate.Add(3);
            }
            if (btn4.Checked)
            {
                raspunsuriDate.Add(4);
            }


            raspunsuriCorecte.Sort();
            raspunsuriDate.Sort();

            if (raspunsuriDate.SequenceEqual(raspunsuriCorecte))
            {

                form.punctaj++;

            }
            this.form.lblPunctaj.Text = "Punctaj = " + form.punctaj;
            this.Visible = false;

        }









    }
}
