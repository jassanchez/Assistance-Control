using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Controlador_de_Asistencia.Formularios.Control_Administrativo
{
    public partial class MenuAdministrativo : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MenuAdministrativo()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e){
            new Personal.RegistroPersonal().Show();
        }

        private void buttonX2_Click(object sender, EventArgs e){
            new Personal.ConsultaPersonal().Show();
        }

        private void buttonX3_Click(object sender, EventArgs e) {
            new Departamentos.RegistroDepartamento().Show();
        }

        private void buttonX4_Click(object sender, EventArgs e) {
            new Departamentos.ConsultaDeDepartamentos().Show();
        }

        private void buttonX6_Click(object sender, EventArgs e) {
            new Configuración.Settings().Show();
        }

        private void MenuAdministrativo_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void buttonX8_Click(object sender, EventArgs e) {
            new Asistencia.AsistenciaPorDia().Show();
        }

        private void buttonX7_Click(object sender, EventArgs e) {
            new Reportes.ReporteUnDia().Show();
        }

        private void buttonX5_Click(object sender, EventArgs e) {
            new Acerca_De.Acerca_De().ShowDialog();
        }
    }
}