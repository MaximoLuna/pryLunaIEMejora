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
    internal partial class frmMain : Form
    {
        public ClsUser UsuarioActual;

        public frmMain(ClsUser UsuarioActual)
        {
            InitializeComponent();

            if (UsuarioActual != null)
            {
                this.UsuarioActual = UsuarioActual; // Usa 'this' para referenciar la variable miembro
            }
            else
            {
                // Maneja el caso en el que usuarioActual sea null si es necesario
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (UsuarioActual != null)
            {
                statusUserMain.Text = UsuarioActual.User;
            }

            if (UsuarioActual.Rol != "Administrador")
            {
                gestiónToolStripMenuItem.Enabled = false;
            }
        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuActivo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        int Contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Contador += 1;

            if (Contador > 1)
            {
                lblDateMenu.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            }
        }

        private void lblUserTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void activosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProveedoresActivos fActivos = new frmProveedoresActivos();
            fActivos.ShowDialog();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProvedores frmRegProv = new frmRegistroProvedores();
            frmRegProv.ShowDialog();

            int idUsuarioActual = UsuarioActual.Id;
            DateTime fechaLog = DateTime.Now.Date;
            string categoria = registroDeProveedoresToolStripMenuItem.Text;

            ClsUser objMenuClick = new ClsUser();
            objMenuClick.MenuLog(idUsuarioActual, fechaLog, categoria);
        }
    }
}
