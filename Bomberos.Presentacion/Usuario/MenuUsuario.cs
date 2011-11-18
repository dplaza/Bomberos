using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomberos.ComunFuncional;

namespace Bomberos.Presentacion
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "Sesión iniciada como " + ContextoDTO.Instancia().BomberoActual.Nombres + " " + ContextoDTO.Instancia().BomberoActual.Apellidos;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = new login();
            form.Show();
        }

        private void buscarBomberoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BuscarBombero();
            form.MdiParent = this;
            form.Show();
        }
    }
}
