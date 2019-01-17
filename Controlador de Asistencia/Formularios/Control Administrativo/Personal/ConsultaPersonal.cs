using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Personal
{
    public partial class ConsultaPersonal : DevComponents.DotNetBar.Metro.MetroForm
    {
        public ConsultaPersonal()
        {
            InitializeComponent();
        }

        private void ConsultaPersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softwareDatabaseDataSet.Personal' Puede moverla o quitarla según sea necesario.
            this.personalTableAdapter.Fill(this.softwareDatabaseDataSet.Personal);
            insertButtonDesign();
        }

        private void dataGridViewX1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void insertButtonDesign()
        {
            // TODO: Se agrega la columna de botón para el datagridview, mayor vista!
            DataGridViewButtonXColumn btn = new DataGridViewButtonXColumn();
            btn.HeaderText = "¿Modificar?";
            btn.Text = "Modificar";
            btn.Name = "BtnModificar";
            btn.Style = eDotNetBarStyle.StyleManagerControlled;
            btn.ColorTable = eButtonColor.BlueWithBackground;
            btn.UseColumnTextForButtonValue = true;
            dataGridViewX1.Columns.Add(btn);
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(dataGridViewX1.Rows[e.RowIndex].Cells[0].Value);
                new ActualizaPersonal(id).ShowDialog();
            }
        }
    }
}