using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using Controlador_de_Asistencia.Base_de_Datos.SoftwareDatabaseDataSetTableAdapters;

namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Personal
{
    public partial class RegistroPersonal : DevComponents.DotNetBar.Metro.MetroForm, DPFP.Capture.EventHandler
    {
        Clases.DigitalPersona lectorBiometrico = new Clases.DigitalPersona();
        DPFP.Capture.Capture capturador = new DPFP.Capture.Capture();
        public delegate void updateEnrollment(uint steps);

        public RegistroPersonal()
        {
            InitializeComponent();
        }

        private void RegistroPersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softwareDatabaseDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
            this.departamentosTableAdapter.Fill(this.softwareDatabaseDataSet.Departamentos);
            capturador.EventHandler = this;
            lectorBiometrico.captura = capturador;
            lectorBiometrico.startCapture();
        }

        private void actualizaCuenta(uint steps)
        {
            if (progressBarX1.InvokeRequired) this.Invoke(new updateEnrollment(actualizaCuenta), steps);
            else progressBarX1.Value = 100-Convert.ToUInt16((steps*100)/4);
        }

        #region Implementación de Captura de Huella Digital

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample) {
            pictureBox1.Image = lectorBiometrico.convertSampletoBitmap(Sample);
            lectorBiometrico.CapturaHuella(Sample);
            actualizaCuenta(lectorBiometrico.CuentaInscripcion);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)   {  }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)  { }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber) { }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) {
            MessageBox.Show("El lector biométrico se encuentra desconectado, si desea asociar la huella más delante, podrá hacerlo en la sección de 'Actualización de información de el personal'", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback) {  }

        #endregion

        private void RegistroPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            lectorBiometrico.stopCapture();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            registro();
        }

        void registro()
        {
            if (MessageBox.Show("¿Desea continuar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                if(codigoUnicoDisponble(textBoxCodigoAux.Text.Trim())) {
                    PersonalTableAdapter insert = new PersonalTableAdapter();
                    if(progressBarX1.Value == 100) {
                        MemoryStream ms = new MemoryStream(lectorBiometrico.plantilla.Bytes);
                        if(insert.InsertQuery(textBoxName.Text, textBoxApellidos.Text, ms.ToArray(), textBoxTelefono.Text, textBoxCodigoAux.Text, Convert.ToInt32(comboBoxDep.SelectedValue)) > 0)
                            MessageBox.Show("Registrado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    } else if(insert.InsertQuery(textBoxName.Text, textBoxApellidos.Text, null, textBoxTelefono.Text, textBoxCodigoAux.Text, Convert.ToInt32(comboBoxDep.SelectedValue)) > 0)
                        MessageBox.Show("Registrado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                } else {
                    MessageBox.Show("El codigo auxiliar ya está en uso, elija otro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool codigoUnicoDisponble(string codigoUnico)
        {
            bool answer = true;
            SqlCeConnection conexion = new SqlCeConnection(ConfigurationManager.ConnectionStrings["Controlador_de_Asistencia.Properties.Settings.SoftwareDatabaseConnectionString"].ToString());
            conexion.Open();
            SqlCeCommand comando = new SqlCeCommand("select * from personal where codigoAuxiliar='" + codigoUnico+"'", conexion);
            SqlCeDataReader lector = comando.ExecuteReader();
            if(lector.Read()) {
                answer = false;
            }
            lector.Close();
            conexion.Close();
            return answer;
        }
    }
}