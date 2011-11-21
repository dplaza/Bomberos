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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Sesión iniciada como " + ContextoDTO.Instancia().BomberoActual.Nombres + " " + ContextoDTO.Instancia().BomberoActual.Apellidos;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

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

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MiFichaBombero();
            form.MdiParent = this;
            form.Show();
        }

        private void registrarBomberoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RegistroBombero();
            form.MdiParent = this;
            form.Show();
        }

        private void buscarBomberoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BuscarBombero();
            form.MdiParent = this;
            form.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Cargos();
            form.MdiParent = this;
            form.Show();
        }

        private void compañiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Compañia();
            form.MdiParent = this;
            form.Show();
        }

        private void premioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Premios();
            form.MdiParent = this;
            form.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Cursos();
            form.MdiParent = this;
            form.Show();
        }


    }
}