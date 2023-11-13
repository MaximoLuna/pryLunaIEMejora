using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaIE
{
    public partial class FrmLogoEmpresa : Form
    {
        public FrmLogoEmpresa()
        {
            InitializeComponent();
        }

        private void FrmLogoEmpresa_Load(object sender, EventArgs e)
        {

        }

        int contadorTiempo = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contadorTiempo += 1000;
            if(contadorTiempo > 3000)
            {
                this.Hide();
                frmInicioSesion FrmInicioSesion = new frmInicioSesion();
                FrmInicioSesion.Show();
                temporizador.Enabled = false;
            }
        }
    }
}
