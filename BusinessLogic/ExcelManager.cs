using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    /// <summary>
    /// Class ExcelManager. Connects with an external excel file and fills it with information
    /// </summary>
    public class ExcelManager
    {
        /// <summary>
        /// Exports the information in the specified file.
        /// </summary>
        /// <param name="path">The path of the file</param>
        /// <param name="week">The actual week</param>
        public void export(string path, int week)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Open(path);

            if (wb.Sheets.Count < 2)
            {
                MessageBox.Show("El archivo de Excel debe tener al menos dos hojas, una hoja de Semana y otra de Boletas.", "Error técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (((Worksheet)wb.Sheets[wb.Sheets.Count]).Name.Split(' ')[0] == "Boletas")
                {
                    Worksheet wsSemana = (Worksheet)wb.Sheets[wb.Sheets.Count - 1];
                    Worksheet wsBoleta = (Worksheet)wb.Sheets[wb.Sheets.Count];

                    if (wsSemana.Name != ("Semana " + week))
                    {
                        wsSemana.Copy(Type.Missing, wb.Sheets[wb.Sheets.Count - 1]); // copy
                        wsSemana = (Worksheet)wb.Sheets[wb.Sheets.Count - 1];
                        wsSemana.Name = "Semana " + week;

                        wsBoleta.Copy(Type.Missing, wb.Sheets[wb.Sheets.Count]); // copy
                        wsBoleta = (Worksheet)wb.Sheets[wb.Sheets.Count];
                        wsBoleta.Name = "Boleta " + week;

                        wsSemana.Move(wb.Sheets[wb.Sheets.Count]);
                        wsBoleta.Move(wb.Sheets[wb.Sheets.Count]);
                    }
                    wsSemana = clearSpaces(wsSemana);
                    wsBoleta.UsedRange.Rows.Clear();

                    List<Employee> missingEmployees = new List<Employee>();
                    bool exists;
                    List<WorkWeekDetail> weeks = new WorkWeekDetail().getWeek(week);

                    for (int i = 0; i < weeks.Count; i++)
                    {
                        exists = false;
                        for (int j = 4; j < wsSemana.UsedRange.Rows.Count; j++)
                        {
                            if (wsSemana.Cells[j, 1].Value == weeks[i].EmployeeCode)
                            {
                                double ordinaryH = 0;
                                double extraH = 0;

                                double actualTotalHours = weeks[i].TotalHours;
                                if (actualTotalHours > 48)
                                {
                                    ordinaryH = 48;
                                    extraH = actualTotalHours - 48;
                                }
                                else
                                {
                                    ordinaryH = actualTotalHours;
                                    extraH = 0;
                                }

                                wsSemana.Cells[j, 6] = ordinaryH;
                                wsSemana.Cells[j, 7] = extraH;
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
                        MessageBox.Show(message, "Requerimientos técnicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                    xla.Visible = true; //Abre el archivo de Excel

                }
                else
                {
                    MessageBox.Show("Fue imposible detectar las hojas de Excel necesarias para el proceso. Se necesita una hoja de Semana, y otra de Boletas. Es posible que el error sea causado por el nombre de las hojas.", "Error técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        /// <summary>
        /// Clears the spaces in the external excel file
        /// </summary>
        /// <param name="ws">The excel file</param>
        /// <returns> the Worksheet without certain information</returns>
        private Worksheet clearSpaces(Worksheet ws)

        {
            for (int i = 4; i < ws.UsedRange.Rows.Count; i++)
            {
                ws.Cells[i, 6] = 0;
                ws.Cells[i, 7] = 0;
            }
            return ws;
        }
    }

}
