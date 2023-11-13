using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryLunaIE
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        int Intentos = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            ClsUser objUser = ClsUser.Login(usuario, contraseña);

            if (objUser != null)
            {
                ClsUser.RegisterLog(usuario);
                this.Hide();
                frmMain forMain = new frmMain(objUser);
                forMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña equivocada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Intentos++;
                MessageBox.Show(Intentos + " de 3 intentos");
                clearText();

                if (Intentos >= 3)
                {
                    MessageBox.Show("Se quedó sin intentos, espere por favor " + (Contador.Interval / 1000) + " segundos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Enabled = false;
                    txtContraseña.Enabled = false;
                    btnLogin.Enabled = false;

                    Contador.Tick += Contador_Tick;
                    Contador.Start();
                }
            }
        }

        public void clearText()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }

        private void Contador_Tick(object sender, EventArgs e)
        {
            // Habilitar el botón y detener el temporizador.
            Intentos = 0;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            btnLogin.Enabled = true;
            Contador.Stop();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtContraseña.Enabled = true;
            }
            else
            {
                txtContraseña.Enabled = false;
            }
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
