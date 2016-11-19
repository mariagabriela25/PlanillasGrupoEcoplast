using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using BusinessLogic;
using System.Threading;

namespace UserInterface
{
    public partial class WelcomeUserControl : MetroFramework.Controls.MetroUserControl
    {
        System.Windows.Forms.DataVisualization.Charting.Chart chart;
        Thread workerThread;
        public WelcomeUserControl()
        {
            InitializeComponent();
            pb.Visible = true;
      
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)(chart)).BeginInit();

            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Entradas";
            legend2.Name = "Salidas";
            chart.Legends.Add(legend1);
            chart.Legends.Add(legend2);
            chart.Location = new System.Drawing.Point(3, 77);
            chart.Name = "chart";
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Entradas";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new System.Drawing.Size(770, 340);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            Controls.Add(chart);
            ((System.ComponentModel.ISupportInitialize)(chart)).EndInit();
            workerThread = new Thread(doWork);
            workerThread.Start();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void doWork() {
            while (true) {

                load();
                workerThread.Suspend();
            }
        }



        public static int GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public static DateTime FirstDateOfWeek(int year, int weekOfYear, System.Globalization.CultureInfo ci)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = (int)ci.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;
            DateTime firstWeekDay = jan1.AddDays(daysOffset);
            int firstWeek = ci.Calendar.GetWeekOfYear(jan1, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
            if ((firstWeek <= 1 || firstWeek >= 52) && daysOffset >= -3)
            {
                weekOfYear -= 1;
            }
            return firstWeekDay.AddDays(weekOfYear * 7);
        }

        private void WelcomeUserControl_Load(object sender, EventArgs e)
        {
        
        }


        private void load() {
        

            DateTime startDate = FirstDateOfWeek(2016, 37-1, CultureInfo.CurrentCulture);
            title.Text += " " + 37 + "   (" + startDate.ToString("dd MMMM, yyyy") + " - " + startDate.AddDays(6).ToString("dd MMMM, yyyy") + ")";
            chart.Visible = false;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            //////////////////////////////////////////////////////
            chart.Series.Clear();
            chart.Series.Add("Horas laboradas");
   
            String[] days = { "Lunes","Martes","Miercoles","Jueves", "Viernes" , "Sabado", "Domingo" };
            for (int i = 0; i < days.Length; i++)
            {
                DataPoint dp = new DataPoint();
                dp.IsValueShownAsLabel = true;
                dp.AxisLabel = days[i];
                dp.YValues = new double[] {(double) new Check().checksbyDate(startDate.AddDays(i), "I") };
                chart.Series[0].Points.Add(dp);
            
            
            }
         
            pb.Visible = false;
            chart.Visible = true;
        }
    }
}
