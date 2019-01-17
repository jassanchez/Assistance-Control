using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using Controlador_de_Asistencia.Base_de_Datos.SoftwareDatabaseDataSetTableAdapters;
using System.Data.SqlServerCe;
using System.Configuration;

namespace Controlador_de_Asistencia.Formularios.Toma_de_Asistencia
{
    public partial class Checador : DevComponents.DotNetBar.Metro.MetroForm, DPFP.Capture.EventHandler
    {
        DataTable personal;

        public Checador() { InitializeComponent(); }

        private void Checador_Load(object sender, EventArgs e){ makeConfiguration(); }

        void makeConfiguration()
        {
            switch(readSetting()) {
                case 1: lecturaBiometria();  break;
                case 2: lecturaBarcode(); break;
                case 3: lecturaPorTeclado(); textBox1.Select(); break;
                default:  MessageBox.Show("Vaya a Configuración para configurar el tipo de entrada del checador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }

        int readSetting() {
            using(FileStream fs = new FileStream("Settings.as", FileMode.Open))
                using(StreamReader sr = new StreamReader(fs)) {
                    fs.Position = 0;
                    using(BinaryReader br = new BinaryReader(fs))
                        return br.ReadInt32();
                }
        }

        bool inputOrOutput(int idPersonal) {
            bool answer=true;
            SqlCeConnection conexion = new SqlCeConnection(ConfigurationManager.ConnectionStrings["Controlador_de_Asistencia.Properties.Settings.SoftwareDatabaseConnectionString"].ToString());
            conexion.Open();
            SqlCeCommand comando = new SqlCeCommand("select top(1) entradasalida from EntradaSalida where idPersonal=" + idPersonal + " order by idEntradaSalida desc", conexion);
            SqlCeDataReader lector = comando.ExecuteReader();
            if(lector.Read()) {
                if(Convert.ToInt16(lector[0]) == 1) answer = false;
                else answer = true;
            }
            lector.Close();
            conexion.Close();
            return answer;
        }

        // TODO: Algoritmos e interfaz incluida para la lectura y verificación por huella digital
        // USO: libreria DPFP Y DigitalPersona.cs
        #region Lectura Por Lector Biometrico

        Clases.DigitalPersona lectorBiometrico=new Clases.DigitalPersona();
        DPFP.Capture.Capture captura=new DPFP.Capture.Capture();
        DPFP.Template plantilla=new DPFP.Template();

        void lecturaBiometria() {
            captura.EventHandler = this;
            lectorBiometrico.captura = captura;
            lectorBiometrico.startCapture();
            groupBoxCodigoAux.Visible = false;
        }

        bool buscarPersonal(DPFP.Sample s) {
            personal = new PersonalTableAdapter().GetData();

            DPFP.FeatureSet caracteristicas = lectorBiometrico.getFeatures(s, DPFP.Processing.DataPurpose.Verification);
            foreach(DataRow row in personal.Rows) {
                int idPersonal = Convert.ToInt32(row["idPersonal"]);
                MemoryStream memoria = new MemoryStream((byte[])row["Biometria"]);
                plantilla.DeSerialize(memoria.ToArray());
                memoria.Dispose(); memoria.Close(); memoria = null;
                if(lectorBiometrico.verificar(caracteristicas,plantilla)){
                    new EntradaSalidaTableAdapter().InsertQuery(DateTime.Now, inputOrOutput(idPersonal), idPersonal);
                    return true;
                }
            }
            return false;
        }

        #region Implementación de Lectura de Huella

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample) {
            buscarPersonal(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }
        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }
        public void OnReaderConnect(object Capture, string ReaderSerialNumber) { }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) { }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback) { }

        #endregion

        #endregion

        #region LecturaPorBarcode

        void lecturaBarcode() {
            timerBarCode.Enabled = true;
        }

        private void timerBarCode_Tick(object sender, EventArgs e) {
            textBox1.Clear();
            textBox1.Select();
        }

        #endregion

        #region LecturaPorTeclado

        void lecturaPorTeclado() {

        }

        #endregion

        // TODO: Método re-usables para la entrada por barcode y por teclado
        #region Entrada por Código Auxiliar

        bool buscarPersonal(string codAuxiliar) {
            personal = new PersonalTableAdapter().GetData();

            foreach(DataRow row in personal.Rows) {
                int idPersonal = Convert.ToInt32(row["idPersonal"]);
                string codAux = row["CodigoAuxiliar"].ToString();
                if(codAux.Equals(codAuxiliar)) {
                    new EntradaSalidaTableAdapter().InsertQuery(DateTime.Now, inputOrOutput(idPersonal), idPersonal);
                    return true;
                }
            }
            return false;
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e) {
            DateTime fecha1 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 00, 00, 00);
            DateTime fecha2 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 23, 59, 59);
            this.entradaSalidaTableAdapter.Fill(this.softwareDatabaseDataSet.EntradaSalida,fecha1,fecha2);
        }

        private void Checador_FormClosing(object sender, FormClosingEventArgs e) {
            lectorBiometrico.stopCapture();
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                buscarPersonal(textBox1.Text.Trim());
                textBox1.Clear();
                textBox1.Select();
            }
        }
    }
}