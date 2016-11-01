using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ExcelManager
    {
        public void export(string path, int week)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Open(path);
            Worksheet ws = (Worksheet)wb.Sheets[1];
            ws.Copy(Type.Missing, wb.Sheets[wb.Sheets.Count]); // copy
            ws = (Worksheet)wb.Sheets[wb.Sheets.Count];
            ws.Name = "Semana " + week;
            ws = clearSpaces(ws);
            xla.Visible = true;


            
            List<WorkWeekDetail> weeks = new WorkWeekDetail().getWeek(week);

            for (int i = 0; i < weeks.Count; i++)
            {
                for (int j = 4; j < ws.UsedRange.Rows.Count; j++)
                {
                    if (ws.Cells[j, 1].Value == weeks[i].EmployeeCode)
                    {
                        ws.Cells[j, 6] = weeks[i].TotalHours;
                    }
                }
            }
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
