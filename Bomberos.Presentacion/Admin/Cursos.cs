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
            dataGridResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridResult.MultiSelect = false;
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

                List<CursoDTO> Lista = new List<CursoDTO>();
                Lista = _Curso.ListarCursos();

                Curso.Nombre = txt_nombres.Text;
                if (!Lista.Exists(p => p.Nombre.Equals(Curso.Nombre)) && _Curso.RegistroCurso(Curso))
                {
                    txt_nombres.Clear();
                    dataGridResult.DataSource = _Curso.ListarCursos().OrderBy(p => p.Nombre).ToList();
                }
                else
                {
                    MessageBox.Show("Error al guardar el nuevo curso");
                }
            }
            else
            {
                MessageBox.Show("Falta rellenar datos");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            ICursoMgr _Curso = new CursoMgr();
            CursoDTO Curso = new CursoDTO();

            Curso = (CursoDTO)dataGridResult.SelectedRows[0].DataBoundItem;

            if (!_Curso.BorrarCurso(Curso))
            {
                MessageBox.Show("Falla al borrar curso");
            }
            else
            {
                dataGridResult.DataSource = _Curso.ListarCursos().OrderBy(p => p.Nombre).ToList();
            }
        }
    }
}
