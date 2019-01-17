using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Asistencia
{
    public partial class AsistenciaPorDia : DevComponents.DotNetBar.Metro.MetroForm
    {
        DateTime fecha1, fecha2;

        public AsistenciaPorDia() {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 00, 00, 00);
            fecha2 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 59, 59);
            refreshData();
        }

        void refreshData() {
            this.entradaSalidaTableAdapter.Fill(this.softwareDatabaseDataSet.EntradaSalida, fecha1, fecha2);
        }

        private void AsistenciaPorDia_Load(object sender, EventArgs e) {
            fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            fecha2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        }
    }
}