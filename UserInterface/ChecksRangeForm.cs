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
using System.IO;
using System.Reflection;
//using iTextSharp.text.pdf;
//using iTextSharp.text;
using System.Diagnostics;

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
            DateTime fDate2 = fDate;
            //fDate2 = fDate2.AddDays(1);
            checksList = new Check().GetChecksWithRests(choosenEmployee.Code, iDate, fDate2);

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
            //try
            //{
            //    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //    folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;

            //    DialogResult result = folderBrowserDialog.ShowDialog();
            //string folderPath = "";
            //if (result == DialogResult.OK)
            //    {
            //        folderPath = folderBrowserDialog.SelectedPath.Replace(@"\", @"\\");
            //    }

            //folderPath += @"\\";

            //    String pdfName = Microsoft.VisualBasic.Interaction.InputBox("Digite el nombre con el que quiere guardar su archivo PDF", "Nombre PDF");
            //pdfName += ".pdf";

            //    PdfPTable pdfTable = new PdfPTable(mgEmployeeRegisteredChecks.ColumnCount);
            //    pdfTable.DefaultCell.Padding = 3;
            //    pdfTable.WidthPercentage = 50;
            //    pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            //    pdfTable.DefaultCell.BorderWidth = 1;

            //    foreach (DataGridViewColumn column in mgEmployeeRegisteredChecks.Columns)
            //    {
            //        PdfPCell pdfCell = new PdfPCell(new Phrase(column.HeaderText));
            //        pdfCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            //        pdfTable.AddCell(pdfCell);
            //    }

            //    foreach (DataGridViewRow row in mgEmployeeRegisteredChecks.Rows)
            //    {
            //        foreach (DataGridViewCell mgCell in row.Cells)
            //        {
            //            pdfTable.AddCell(mgCell.Value.ToString());
            //        }
            //    }
                
            //    if (!Directory.Exists(folderPath))
            //    {
            //        Directory.CreateDirectory(folderPath);
            //    }
            //    using (FileStream stream = new FileStream(folderPath + pdfName, FileMode.Create))
            //    {
            //        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            //        PdfWriter.GetInstance(pdfDoc, stream);

            //        pdfDoc.Open();

            //        Paragraph p1 = new Paragraph(lbDepartment.Text);
            //        p1.Alignment = Element.ALIGN_CENTER;
            //        Paragraph p2 = new Paragraph(lbDates.Text);
            //        p2.Alignment = Element.ALIGN_CENTER;
            //        Paragraph p3 = new Paragraph(lbEmployeeNumber.Text + "     " + lbEmployeeName.Text);
            //        p3.Alignment = Element.ALIGN_CENTER;
            //        Paragraph p4 = new Paragraph("   ");

            //        pdfDoc.Add(p1);
            //        pdfDoc.Add(p2);
            //        pdfDoc.Add(p3);
            //        pdfDoc.Add(p4);
            //        pdfDoc.Add(pdfTable);

            //        pdfDoc.Close();
            //        stream.Close();
                    
            //        Process.Start(folderPath + pdfName);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ocurrió un problema al generar el archivo .pdf, asegúrese de que el nombre que eligió para el archivo aún no exista en la carpeta destino ¡Inténtelo de nuevo!");
            //}
        }
    }
}
