using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Controlador_de_Asistencia.Base_de_Datos.SoftwareDatabaseDataSetTableAdapters;
using SpreadsheetLight;

namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Reportes
{
    public partial class ReporteUnDia : DevComponents.DotNetBar.Metro.MetroForm
    {
        DataTable datos = new DataTable();
        DateTime fecha1, fecha2;

        public ReporteUnDia() {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e) {
            fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 00, 00, 00);
            fecha2 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 59, 59);
            makeReport();
        }

        void makeReport() {
            SaveFileDialog savePrompt = new SaveFileDialog();
            savePrompt.Filter = "Excel File|*.xlsx";
            savePrompt.Title = "Guardar Reporte";
            savePrompt.ShowDialog();

            SLDocument report = new SLDocument("Template.xlsx");
            getData();

            //report.ImportDataTable(2, 1, datos, false);
            int contador = 2;
            foreach(DataRow row in datos.Rows) {
                report.SetCellValue("A" + contador.ToString(), row["Fecha"].ToString());
                SLStyle estilo = new SLStyle();
                estilo.FormatCode = "dd/MM/yy hh:mm:ss";
                report.SetCellStyle("A" + contador.ToString(), estilo);
                report.SetCellValue("B" + contador.ToString(), row["entradaSalida"].ToString());
                report.SetCellValue("C" + contador.ToString(), row["Nombre"].ToString());
                report.SetCellValue("D" + contador.ToString(), row["Departamento"].ToString());
                /*string formula = "=SI(B"+contador.ToString()+"=\"\" , \"\", SI(IGUAL(B"+contador.ToString()+",\"True\"),\"Entrada Laboral\",\"Salida Laboral\"))";
                //MessageBox.Show(formula);
                report.SetCellValue("E" + contador.ToString(),formula );*/
                contador++; 
            }
            report.AutoFitColumn(1, 5);
            report.SaveAs(savePrompt.FileName);
            report.Dispose();
        }

        void getData() {
            datos.Clear();
            datos = new EntradaSalidaTableAdapter().GetData(fecha1, fecha2);
        }
    }
}