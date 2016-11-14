using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class ExcelManager
    {
        public void export(string path, int week)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Open(path);
            Worksheet ws = (Worksheet)wb.Sheets[1];
            if (ws.Name != ("Semana " + week))
            {
                ws.Copy(Type.Missing, wb.Sheets[wb.Sheets.Count]); // copy
                ws = (Worksheet)wb.Sheets[wb.Sheets.Count];
                ws.Name = "Semana " + week;
            }
            ws = clearSpaces(ws);

            List<Employee> missingEmployees = new List<Employee>();
            bool exists;
            List<WorkWeekDetail> weeks = new WorkWeekDetail().getWeek(week);

            //weeks.Add(new WorkWeekDetail
            //{
            //    EmployeeCode = 1000,
            //    Name = "Usuario de prueba1"
            //});
            //weeks.Add(new WorkWeekDetail
            //{
            //    EmployeeCode = 2000,
            //    Name = "Usuario de prueba2"
            //});

            for (int i = 0; i < weeks.Count; i++)
            {
                exists = false;
                for (int j = 4; j < ws.UsedRange.Rows.Count; j++)
                {
                    if (ws.Cells[j, 1].Value == weeks[i].EmployeeCode)
                    {
                        ws.Cells[j, 6] = weeks[i].TotalHours;
                        exists = true;
                    }
                }
                if (!exists)
                {
                    missingEmployees.Add(new Employee
                    {
                        Name = weeks[i].Name,
                        Code = weeks[i].EmployeeCode
                    });
                }
            }


            if (missingEmployees.Count > 0)
            {
                string message = "";
                if (missingEmployees.Count == 1)
                {
                    message = "El empleado " + missingEmployees[0].Name +
                        " de código " + missingEmployees[0].Code +
                        " no fue encontrado en el archivo de Excel, favor agregarlo manualmente para el reporte de esta semana.";
                }
                else
                {
                    message = "Los siguientes empleados no fueron encontrados en el archivo de Excel, favor agregarlos manualmente para el reporte de esta semana.";
                    foreach (Employee e in missingEmployees)
                    {
                        message += Environment.NewLine + e.Code + ") " + e.Name;
                    }
                }
                MessageBox.Show(message,"Requerimientos técnicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            xla.Visible = true; //Abre el archivo de Excel
        }

        private Worksheet clearSpaces(Worksheet ws)
        {
            for (int i = 4; i < ws.UsedRange.Rows.Count; i++)
            {
                ws.Cells[i, 6] = 0;
                ws.Cells[i, 7] = 0;
                ws.Cells[i, 8] = 0;
                ws.Cells[i, 9] = 0;
                ws.Cells[i, 10] = 0;
            }
            return ws;
        }
    }

}
