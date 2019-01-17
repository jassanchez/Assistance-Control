using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Configuración
{
    public partial class Settings : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Settings() {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e) {
            if(!File.Exists("Settings.as")) writeSetting(1);
            settingSelected(readSetting());
        }

        void writeSetting(int type) {
            using(FileStream fs = new FileStream("Settings.as", FileMode.Create)) 
                using(BinaryWriter bw = new BinaryWriter(fs)) 
                    bw.Write(type);
        }

        int readSetting() {
            using(FileStream fs = new FileStream("Settings.as", FileMode.Open))
                using(StreamReader sr = new StreamReader(fs)) {
                    fs.Position = 0;
                    using(BinaryReader br = new BinaryReader(fs))
                        return br.ReadInt32();
                }
        }

        void settingSelected(int i) {
            switch(i) {
                case 1: radioButton1.Checked = true;
                    break;
                case 2: radioButton2.Checked = true;
                    break;
                case 3: radioButton3.Checked = true;
                    break;
            }
        }

        int setSettingValue() {
            if(radioButton1.Checked) return 1;
            else if(radioButton2.Checked) return 2;
            else if(radioButton3.Checked) return 3;
            return -1;
        }

        private void buttonX1_Click(object sender, EventArgs e) {
            if(MessageBox.Show("¿Desea guardar los cambios?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                writeSetting(setSettingValue());
                MessageBox.Show("Sus cambios fueron aplicados. Reinicie el programa para que surta efecto","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Close();
            }
        }
    }
}