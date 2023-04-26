using CENTENARUL_MARII_UNIRI.Controllers;
using CENTENARUL_MARII_UNIRI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CENTENARUL_MARII_UNIRI.Panel_uri
{
    internal class pnleLearning1918_Elev : Panel
    {
        Form1 form;
        private int id;

        Label lblTitlu;
        Label lblPunctaj;
        Button btnStart;
        Label lblNume;
        TabControl tabControl1;
        TabPage tabTeste;
        TabPage tabCaiet;
        TabPage tabGrafic;
        Panel panel1;
        Button btnRaspund;
        DataGridView dataGridView1;
        DataGridViewTextBoxColumn nota;
        DataGridViewTextBoxColumn data;
        Chart chart;
        ChartArea chartArea;
        Legend legend;
        Series series;
        Series series2;


        private List<Evaluare> listEvaluari;
        private List<int> listClasa;
        private List<int> listNote;
        private int media;

        ControllerEvaluari controllerEvaluari;
        ControllerUtilizatori controllerUtilizatori;

        public pnleLearning1918_Elev(Form1 form1, int id1)
        {

            form = form1;
            id = id1;

            //pnleLearning1918
            this.form.MaximumSize = new System.Drawing.Size(1172, 676);
            this.form.MinimumSize = new System.Drawing.Size(1172, 676);
            this.form.Size = new System.Drawing.Size(1172, 676);
            this.Size = new System.Drawing.Size(1172, 676);
            this.Name = "pnleLearning1918_Elev";
            this.Text = "eLearning1918_Elev";

            //New
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblPunctaj = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTeste = new System.Windows.Forms.TabPage();
            this.tabCaiet = new System.Windows.Forms.TabPage();
            this.tabGrafic = new System.Windows.Forms.TabPage();
            this.btnRaspund = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listEvaluari = new List<Evaluare>();
            this.controllerEvaluari = new ControllerEvaluari();
            this.controllerUtilizatori = new ControllerUtilizatori();
            this.listClasa = new List<int>();
            this.listNote = new List<int>();
            this.chart = new Chart();
            this.legend = new Legend();
            this.chartArea = new ChartArea();
            this.series = new Series();
            this.series2 = new Series();

            //Add
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblTitlu);

            string clasa = controllerUtilizatori.clasaByid(id);
            listClasa = controllerUtilizatori.getidsByclasa(clasa);
            media = controllerEvaluari.getmediaClasa(listClasa);
            listNote = controllerEvaluari.getNoteById(id);

            // tabControl1
            tabControl();

            //tabPages
            tabPages();

            // lblTitlu
            lbltitlu();

            // lblPunctaj
            lblpunctaj();

            // lblNume
            lblnume();

            // btnStart
            btnstart();

            // btnRaspund
            btnraspund();

            //chart
            createChart();

            // dataGridView1
            datagrid();

        }

        private void datagrid()
        {


            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nota,
            this.data});
            this.dataGridView1.Location = new System.Drawing.Point(122, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 408);

            listEvaluari = controllerEvaluari.getEvaluariById(id);

            foreach (var item in listEvaluari)
            {

                dataGridView1.Rows.Add(item.getNota(), item.getDate());

            }

            // nota
            this.nota.HeaderText = "Nota";
            this.nota.MinimumWidth = 6;
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            this.nota.Width = 350;

            // data
            this.data.HeaderText = "Data";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 350;

        }

        private void tabControl()
        {

            this.tabControl1.Controls.Add(this.tabTeste);
            this.tabControl1.Controls.Add(this.tabCaiet);
            this.tabControl1.Controls.Add(this.tabGrafic);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.tabControl1.Location = new System.Drawing.Point(32, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1180, 543);

        }

        private void tabPages()
        {

            // tabTeste
            this.tabTeste.Controls.Add(this.btnRaspund);
            this.tabTeste.Controls.Add(this.btnStart);
            this.tabTeste.Controls.Add(this.lblPunctaj);
            this.tabTeste.Location = new System.Drawing.Point(4, 33);
            this.tabTeste.Name = "tabTeste";
            this.tabTeste.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeste.Size = new System.Drawing.Size(1172, 506);
            this.tabTeste.Text = "Teste";

            // tabCaiet
            this.tabCaiet.Controls.Add(this.dataGridView1);
            this.tabCaiet.Controls.Add(this.lblNume);
            this.tabCaiet.Location = new System.Drawing.Point(4, 33);
            this.tabCaiet.Name = "tabCaiet";
            this.tabCaiet.Size = new System.Drawing.Size(1172, 506);
            this.tabCaiet.Text = "Caiet de note";

            // tabGrafic
            this.tabGrafic.Controls.Add(this.chart);
            this.tabGrafic.Location = new System.Drawing.Point(4, 33);
            this.tabGrafic.Name = "tabGrafic";
            this.tabGrafic.Size = new System.Drawing.Size(1172, 506);
            this.tabGrafic.Text = "Grafic";

        }

        private void createChart()
        {

            this.chart.Location = new System.Drawing.Point(156, 64);
            this.chart.Size = new System.Drawing.Size(853, 405);
            this.chart.Legends.Add(legend);
            this.chart.Name = "chart";
            this.chart.Text = "chart";
            this.chart.Series.Add(series);
            this.chart.Series.Add(series2);
            this.chart.ChartAreas.Add(chartArea);
            this.chartArea.AxisX.LabelStyle.Enabled = false;
            this.series.BorderWidth = 10;
            this.chartArea.AxisX.Minimum = 0;
            this.series2.BorderWidth = 10;
            this.chartArea.AxisY.Interval = 1;
            this.chartArea.Name = "ChartArea";
            this.legend.Name = "Legend";
            this.series.ChartType = SeriesChartType.Line;
            this.series2.ChartType = SeriesChartType.Line;

            for (int i = 0; i < listNote.Count; i++)
            {
                DataPoint datapoint = new DataPoint(0, listNote[i]);

                series.Points.Add(datapoint);

                DataPoint dataPoint1 = new DataPoint(0, media);
                series2.Points.Add(dataPoint1);

            }
            this.series.LegendText = "Notele mele";
            this.series2.LegendText = "Media clasa";

        }

        private void lbltitlu()
        {
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblTitlu.Location = new System.Drawing.Point(27, 9);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(151, 36);
            this.lblTitlu.Text = "Meniu elev";

        }

        private void lblpunctaj()
        {

            this.lblPunctaj.AutoSize = true;
            this.lblPunctaj.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.lblPunctaj.Location = new System.Drawing.Point(269, 36);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(79, 27);
            this.lblPunctaj.Text = "Punctaj = 1";

        }

        private void lblnume()
        {

            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblNume.Location = new System.Drawing.Point(259, 26);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(345, 36);
            string nume = controllerUtilizatori.numeByid(id);
            this.lblNume.Text = "Caietul de note al elevului " + nume;

        }

        private void btnstart()
        {
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.btnStart.Location = new System.Drawing.Point(48, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 42);
            this.btnStart.Text = "Start";
        }

        private void btnraspund()
        {
            this.btnRaspund.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaspund.Location = new System.Drawing.Point(950, 446);
            this.btnRaspund.Name = "btnRaspund";
            this.btnRaspund.Size = new System.Drawing.Size(124, 42);
            this.btnRaspund.Text = "Raspund";
        }


    }
}
