using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador_de_Asistencia
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            new Formularios.Toma_de_Asistencia.Checador().Show();
            this.Close();
        }

        private void Splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                timer1.Enabled = false;
                new Formularios.Control_Administrativo.MenuAdministrativo().Show();
                this.Close();
            }
        }
    }
}
