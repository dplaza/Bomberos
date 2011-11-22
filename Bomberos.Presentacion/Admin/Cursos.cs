using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomberos.Negocio.Mgr;
using Bomberos.Comun;

namespace Bomberos.Presentacion
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            ICursoMgr _Curso = new CursoMgr();
            dataGridResult.DataSource = _Curso.ListarCursos().OrderBy(p => p.Nombre).ToList();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombres.Text != "")
            {
                ICursoMgr _Curso = new CursoMgr();
                CursoDTO Curso = new CursoDTO();

                Curso.Nombre = txt_nombres.Text;
                if (_Curso.RegistroCurso(Curso))
                {
                    txt_nombres.Clear();
                    dataGridResult.DataSource = _Curso.ListarCursos().OrderBy(p => p.Nombre).ToList();
                }
            }
            else
            {
                MessageBox.Show("Falta rellenar datos");
            }
        }
    }
}
