using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Departamentos
{
    public partial class ConsultaDeDepartamentos : DevComponents.DotNetBar.Metro.MetroForm
    {
        public ConsultaDeDepartamentos() {
            InitializeComponent();
        }

        private void ConsultaDeDepartamentos_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'softwareDatabaseDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
            this.departamentosTableAdapter.Fill(this.softwareDatabaseDataSet.Departamentos);
            insertButtonDesign();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == 2)
                if(MessageBox.Show("¿Está Seguro de Eliminar este departamento?, el eliminar este departamento tambien eliminará al personal que se encuentre registrado en él", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    int id = Convert.ToInt32(dataGridViewX1.Rows[e.RowIndex].Cells[0].Value);
                    new Base_de_Datos.SoftwareDatabaseDataSetTableAdapters.DepartamentosTableAdapter().DeleteQuery(id);
                    MessageBox.Show("Eliminación concretada","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }         
        }

        private void insertButtonDesign() {
            // TODO: Se agrega la columna de botón para el datagridview, mayor vista!
            DataGridViewButtonXColumn btn = new DataGridViewButtonXColumn();
            btn.HeaderText = "¿ELIMINAR?";
            btn.ImageFixedSize = new Size(30, 30);
            btn.Image = Controlador_de_Asistencia.Properties.Resources.cancel;
            btn.Name = "BtnDelete";
            btn.Style = eDotNetBarStyle.StyleManagerControlled;
            btn.ColorTable = eButtonColor.OrangeWithBackground;
            btn.UseColumnTextForButtonValue = true;
            dataGridViewX1.Columns.Add(btn);
        }
    }
}