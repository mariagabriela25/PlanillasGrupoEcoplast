using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using System.Windows.Controls;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace UserInterface
{
    public partial class ChecksRangeForm : MetroFramework.Forms.MetroForm
    {
        private DataTable dt;
        public Employee choosenEmployee;
        public DateTime iDate;
        public DateTime fDate;

        private PrintDocument printDocument1 = new PrintDocument();
        Bitmap memoryImage;

        public ChecksRangeForm(Employee e, DateTime iniDate, DateTime finDate)
        {
            InitializeComponent();
            choosenEmployee = e;
            iDate = iniDate;
            fDate = finDate;
        }

        private void ChecksRangeForm_Load(object sender, EventArgs e)
        {
            
            lbDates.Text = iDate.Day+ "/"+iDate.Month+"/"+iDate.Year + " a " + fDate.Day + "/" + fDate.Month + "/" + fDate.Year;
            lbEmployeeNumber.Text = choosenEmployee.Code+"";
            lbEmployeeName.Text = choosenEmployee.Name;
            lbDepartment.Text = choosenEmployee.Department.Name;

            dt = new DataTable();
            dt.Columns.Add("Día");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Marca");

            List<Check> checksList = new List<Check>();
            checksList = new Check().GetChecksWithRests(choosenEmployee.Code, iDate, fDate);

            if (checksList != null)
            {
                foreach (Check c in checksList)
                {
                    String cDay = c.CheckTime.DayOfWeek.ToString();
                    switch (cDay)
                    {
                        case "Monday":
                            cDay = "Lunes";
                            break;
                        case "Tuesday":
                            cDay = "Martes";
                            break;
                        case "Wednesday":
                            cDay = "Miércoles";
                            break;
                        case "Thursday":
                            cDay = "Jueves";
                            break;
                        case "Friday":
                            cDay = "Viernes";
                            break;
                        case "Saturday":
                            cDay = "Sábado";
                            break;
                        case "Sunday":
                            cDay = "Domingo";
                            break;
                        default:
                            break;
                    }
                    dt.Rows.Add(cDay,c.CheckTime.Day + "/" + c.CheckTime.Month + "/" + c.CheckTime.Year,c.CheckTime.TimeOfDay, c.CheckType);
                }
                mgEmployeeRegisteredChecks.DataSource = dt;

                mgEmployeeRegisteredChecks.RowHeadersWidth = 4;

                mgEmployeeRegisteredChecks.AutoResizeColumns();
                //mgEmployeeRegisteredChecks.AutoSize = true;
                mgEmployeeRegisteredChecks.UseStyleColors = true;
                mgEmployeeRegisteredChecks.Height = SystemInformation.VirtualScreen.Height-200;
            }
           

        }


        private void mbPrint_Click(object sender, EventArgs e)
        {
            mbPrint.Click += new EventHandler(mbPrint_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(mbPrint);

            CaptureScreen();
            printDocument1.Print();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(mgEmployeeRegisteredChecks.Width, mgEmployeeRegisteredChecks.Height+200, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
