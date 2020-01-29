using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Controlador_de_Asistencia.Base_de_Datos.SoftwareDatabaseDataSetTableAdapters;
using System.IO;
using System.Data.SqlServerCe;
using System.Configuration;

namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Personal
{
    public partial class ActualizaPersonal : DevComponents.DotNetBar.Metro.MetroForm,DPFP.Capture.EventHandler
    {
        private int idPersonal;
        private Clases.DigitalPersona lectorBiometrico = new Clases.DigitalPersona();
        private DPFP.Capture.Capture capturador = new DPFP.Capture.Capture();
        public delegate void updateEnrollment(uint steps);
        public delegate void buttonFingerBlock(bool blocked);
        int idPersonalBd;


        public ActualizaPersonal(int idPersonal)
        {
            InitializeComponent();
            this.idPersonal = idPersonal;
            capturador.EventHandler = this;
            lectorBiometrico.captura = capturador;
            lectorBiometrico.startCapture();
        }

        private void ActualizaPersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softwareDatabaseDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
            this.departamentosTableAdapter.Fill(this.softwareDatabaseDataSet.Departamentos);
            busqueda(idPersonal);

        }

        private void actualizaCuenta(uint steps)
        {
            if (progressBarX1.InvokeRequired) this.Invoke(new updateEnrollment(actualizaCuenta), steps);
            else progressBarX1.Value = 100 - Convert.ToUInt16((steps * 100) / 4);
        }

        private void bloqueoBoton(bool blocked)
        {
            if (buttonX2.InvokeRequired) this.Invoke(new buttonFingerBlock(bloqueoBoton), blocked);
            else
                if (blocked) buttonX2.Enabled = false;
                else buttonX2.Enabled = true;
        }

        private void busqueda(int id) {
            DataTable datos;
            datos = new PersonalTableAdapter().GetDataPersonal(idPersonal);
            DataRow renglon = datos.Rows[0];

            textBoxName.Text = renglon["Nombres"].ToString();
            textBoxApellidos.Text = renglon["Apellidos"].ToString();
            textBoxTelefono.Text = renglon["Telefono"].ToString();
            textBoxCodigoAux.Text = renglon["CodigoAuxiliar"].ToString();
            comboBoxDep.SelectedValue = Convert.ToInt32(renglon["idDepartamento"].ToString());
        }

        #region Lectura de la huella digital

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            pictureBox1.Image = lectorBiometrico.convertSampletoBitmap(Sample);
            lectorBiometrico.CapturaHuella(Sample);
            actualizaCuenta(lectorBiometrico.CuentaInscripcion);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)  { }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber) {
            bloqueoBoton(false);
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) {
            bloqueoBoton(true);
            MessageBox.Show("Conecte el lector biometrico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback) { }

        #endregion

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (progressBarX1.Value == 100)
            {
                MemoryStream ms = new MemoryStream(lectorBiometrico.plantilla.Bytes);
                new PersonalTableAdapter().UpdateBiometria(ms.ToArray(), idPersonal);
                ms.Dispose();
                ms.Close();
                ms = null;
                MessageBox.Show("La biometría fue actualizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
                MessageBox.Show("Termine la comprobación de la biometría para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de actualizar los datos básicos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if(codigoUnicoDisponble(textBoxCodigoAux.Text.Trim())) {
                    new PersonalTableAdapter().UpdateInfo(textBoxName.Text, textBoxApellidos.Text, textBoxTelefono.Text, textBoxCodigoAux.Text, Convert.ToInt32(comboBoxDep.SelectedValue), idPersonal);
                    MessageBox.Show("Actualizado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                } else {
                    MessageBox.Show("El codigo auxiliar ya está en uso, elija otro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizaPersonal_FormClosing(object sender, FormClosingEventArgs e) {
            lectorBiometrico.stopCapture();
        }

        bool codigoUnicoDisponble(string codigoUnico) {
            bool answer = true;
            SqlCeConnection conexion = new SqlCeConnection(ConfigurationManager.ConnectionStrings["Controlador_de_Asistencia.Properties.Settings.SoftwareDatabaseConnectionString"].ToString());
            conexion.Open();
            SqlCeCommand comando = new SqlCeCommand("select * from personal where codigoAuxiliar='" + codigoUnico + "'", conexion);
            SqlCeDataReader lector = comando.ExecuteReader();
            if(lector.Read()) {
                idPersonalBd = Convert.ToInt32(lector["idPersonal"].ToString());
                answer = false;
            }
            lector.Close();
            conexion.Close();
            return answer || (idPersonal==idPersonalBd);
        }

        private void comboBoxDep_SelectedIndexChanged(object sender, EventArgs e) {
        }
    }
}