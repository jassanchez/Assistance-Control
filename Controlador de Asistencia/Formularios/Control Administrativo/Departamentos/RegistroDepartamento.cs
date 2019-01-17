using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Departamentos
{
    public partial class RegistroDepartamento : DevComponents.DotNetBar.Metro.MetroForm
    {
        public RegistroDepartamento() {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Desea registrar a este departamento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                new Base_de_Datos.SoftwareDatabaseDataSetTableAdapters.DepartamentosTableAdapter().InsertQuery(textBoxX1.Text.Trim());
                MessageBox.Show("Registro Completo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}