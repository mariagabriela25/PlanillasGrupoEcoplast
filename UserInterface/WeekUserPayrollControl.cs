using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class WeekUserPayrollControl : MetroFramework.Controls.MetroUserControl
    {
        int counter = 0;
        private List<Employee> list_empl; //lista de todos los empleados para cargar el cbo_employee
        private List<WorkDayDetail> list_days; // la info que voy a cargar al grid
        private WorkWeekDetail week; //objeto para recuperar las semanas (numSemana) trabajadas por el empleado elegido
        private Employee employee; //objeto para usar el método getAllEmployees()
        int employee_selected; //empleado elegido (el código)

        public WeekUserPayrollControl()
        {
            InitializeComponent();
        }


        //carga en el cbo todos los empleados al inicio.
        //cbo_employee --> display = nombre y apellidos, value = el código el empleado
        private void WeekUserPayrollControl_Load(object sender, EventArgs e) 
        {
            list_empl = new List<Employee>();
            employee = new Employee();
            list_empl = employee.GetAllEmployees();

            // lo que sigue es necesario para poder mostrar el nombre pero que el valor sea el código (no se por qué)
            //(para después ir a buscar las semanas usando ese código de empleado)
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Codigo");

            foreach (Employee empl in list_empl)
            {
                dt.Rows.Add(empl.Name + " " + empl.LastName,empl.Code);
            }

            cbo_employee.DisplayMember = "Nombre";
            cbo_employee.ValueMember = "Codigo";
            cbo_employee.DataSource = dt;
        }

        //se ejecuta cuando ocurre el evento ValueChanged del cbo_employee(o sea cuando se escoge el empleado)
        //muestro en el cbo_weeks únicamente las semanas que ese empleado ha trabajado (solo el número de la semana).
        private void cbo_employee_selected(object sender, EventArgs e) {

            week = new WorkWeekDetail();

            if (counter > 1)
            {
                employee_selected = Int32.Parse((String)cbo_employee.SelectedValue);
                cbo_Weeks.DataSource = week.getEmployeeWeeks(employee_selected);
            }
            counter++;
        }

        //me traigo la info de los días pertenecientes a la semana escogida. envio el cod de empleado
        //y la semana elegida
        private void mt_generate_Click(object sender, EventArgs e)
        {
            list_days = new List<WorkDayDetail>();
            WorkDayDetail work = new WorkDayDetail();
            list_days = work.getWeeks(employee_selected, (Int32)cbo_Weeks.SelectedValue);
            mg_weekDetail.DataSource = list_days;

            //crear datatable con las columnas y los datos a mostrar, para luego usarlo como datasource del grid.
        }
    }
}
