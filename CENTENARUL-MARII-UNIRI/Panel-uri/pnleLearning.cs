using CENTENARUL_MARII_UNIRI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CENTENARUL_MARII_UNIRI.Panel_uri
{
    internal class pnleLearning:Panel
    {
        PictureBox pctImg;
        Label lblTitlu;
        Label lblEmail;
        Label lblParola;
        TextBox txtEmail;
        TextBox txtParola;
        Button btnLogin;
        PictureBox pctLogin;
        Button btnInainte;
        Button btnStart;
        Button btnStop;
        Button btnInapoi;
        Label lblTitlu2;
        RichTextBox txtDes;
        Timer time;

        Form1 form;
  
        ControllerUtilizatori controllerUtilizatori;


        public pnleLearning(Form1 form1)
        {
            form = form1;
            controllerUtilizatori = new ControllerUtilizatori();
            this.form.MaximumSize = new System.Drawing.Size(1263, 625);
            this.form.MinimumSize = new System.Drawing.Size(1263, 625);
            this.form.Size = new System.Drawing.Size(1263, 625);

            this.Size = new System.Drawing.Size(1263, 625);
            this.Name = "pnleLearning";
            this.Text = "eLearning";

            this.pctImg = new PictureBox();
            this.lblTitlu = new Label();
            this.lblEmail = new Label();
            this.lblParola = new Label();
            this.txtEmail = new TextBox();
            this.txtParola = new TextBox();
            this.btnLogin = new Button();
            this.pctLogin = new PictureBox();
            this.btnInainte = new Button();
            this.btnStart = new Button();
            this.btnInapoi = new Button();
            this.lblTitlu2 = new Label();
            this.txtDes = new RichTextBox();
            this.btnStop = new Button();
            this.time = new Timer();

            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lblTitlu2);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnInainte);
            this.Controls.Add(this.pctLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pctImg);
            this.Controls.Add(this.btnStop);

            //time
            this.time.Enabled = false;
            this.time.Interval = 2000;
            this.time.Tick += new EventHandler(time_Tick);

            // pctImg
            this.pctImg.Location = new System.Drawing.Point(350, 86);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(469, 342);
            this.pctImg.SizeMode = PictureBoxSizeMode.StretchImage;
            string path1 = Application.StartupPath + @"/imagini/" + poz.ToString() + ".jpg";
            this.pctImg.Image = Image.FromFile(path1);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblTitlu.Location = new System.Drawing.Point(926, 62);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Text = "Intra in aplicatie";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.lblEmail.Location = new System.Drawing.Point(844, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email";

            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.lblParola.Location = new System.Drawing.Point(844, 229);
            this.lblParola.Name = "lblParola";
            this.lblParola.Text = "Parola";

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txtEmail.Location = new System.Drawing.Point(953, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 34);

            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txtParola.Location = new System.Drawing.Point(953, 226);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(259, 34);

            // btnLogin
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.btnLogin.Location = new System.Drawing.Point(979, 324);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 42);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new EventHandler(btnLogin_Click);

            // pctLogin
            this.pctLogin.Location = new System.Drawing.Point(922, 409);
            this.pctLogin.Name = "pctLogin";
            this.pctLogin.Size = new System.Drawing.Size(225, 130);
            string path = Application.StartupPath + @"/user.bmp";
            this.pctLogin.Image = Image.FromFile(path);
            this.pctLogin.SizeMode = PictureBoxSizeMode.StretchImage;

            // btnInainte
            this.btnInainte.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.btnInainte.Location = new System.Drawing.Point(682, 472);
            this.btnInainte.Name = "btnInainte";
            this.btnInainte.Size = new System.Drawing.Size(124, 42);
            this.btnInainte.Text = "Inainte";
            this.btnInainte.Click += new EventHandler(btnInainte_Click);

            // btnStart
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.btnStart.Location = new System.Drawing.Point(512, 472);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 42);
            this.btnStart.Text = "Auto";
            this.btnStart.Click += new EventHandler(btnStart_Click);

            // btnStop
            this.btnStop.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.btnStop.Location = new System.Drawing.Point(512, 472);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(124, 42);
            this.btnStop.Text = "Manual";
            this.btnStop.Click += new EventHandler(btnStop_Click);
            this.btnStop.Visible = false;

            // btnInapoi
            this.btnInapoi.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.btnInapoi.Location = new System.Drawing.Point(350, 472);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(124, 42);
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.Click += new EventHandler(btnInapoi_Click);

            // lblTitlu2
            this.lblTitlu2.AutoSize = true;
            this.lblTitlu2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblTitlu2.Location = new System.Drawing.Point(41, 99);
            this.lblTitlu2.Name = "lblTitlu2";
            this.lblTitlu2.Size = new System.Drawing.Size(214, 36);
            this.lblTitlu2.Text = "Despre aplicatie";

            // txtDes
            this.txtDes.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.txtDes.Location = new System.Drawing.Point(12, 148);
            this.txtDes.Name = "txtDes";
            this.txtDes.ReadOnly = true;
            this.txtDes.Size = new System.Drawing.Size(328, 124);
            this.txtDes.Text = "Aceasta platforma eLearning \neste dedicata Marii Uniri de la 1918.\nLa 1 decembrie" +
            " 2018 se implineste \n100 de ani de la Unirea Transilvaniei, \nBanatului, Crisanei" +
            " si Maramusesului \ncu Romania.\n\n";

        }
        private int poz = 1;
      
        private void time_Tick(object sender, EventArgs e)
        {

            if (poz == 5)
            {
                poz = 0;
            }
            else
            {
                poz++;
                this.pctImg.Image = Image.FromFile(Application.StartupPath + @"/imagini/" + poz.ToString() + ".jpg");
            }

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            poz--;
            if(poz == 0)
            {
                poz = 5;
            }
            //MessageBox.Show(poz.ToString());
            this.pctImg.Image = Image.FromFile(Application.StartupPath + @"/imagini/" + poz.ToString() + ".jpg");

        }

        private void btnInainte_Click(object sender, EventArgs e)
        {

            poz++;
            if (poz == 6)
            {
                poz = 1;

            }

            this.pctImg.Image = Image.FromFile(Application.StartupPath + @"/imagini/" + poz.ToString() + ".jpg");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            this.btnStart.Visible = false;
            this.btnStop.Visible = true;
            this.time.Enabled = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            this.btnStop.Visible = false;
            this.btnStart.Visible = true;
            this.time.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string parola = txtParola.Text;

            if (controllerUtilizatori.verifAut(email,parola))
            {
                this.form.removePnl("pnleLearning");
                int id=controllerUtilizatori.idByemail(email);
                this.form.Controls.Add(new pnleLearning1918_Elev(this.form, id));
            }
            else
            {

                MessageBox.Show("Eroare autentificare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtParola.Text = "";
            }


        }

    }
}
