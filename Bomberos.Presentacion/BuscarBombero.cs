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
using Bomberos.ComunFuncional;
using Bomberos.Presentacion.Admin;
using Bomberos.Presentacion.Usuario;

namespace Bomberos.Presentacion
{
    public partial class BuscarBombero : Form
    {
        public BuscarBombero()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            IBomberoMgr _Bombero = new BomberoMgr();
            dataGridResult.DataSource = _Bombero.ListarBomberos().FindAll(p => p.Nombres.Contains(txt_nombres.Text) && p.Apellidos.Contains(txt_apellidos.Text) && p.Rut.Contains(txt_rut.Text) && p.TIB.Contains(txt_tib.Text));
            dataGridResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridResult.MultiSelect = false;
            
        }

        private void dataGridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            if (dataGridResult.SelectedRows.Count != 0)
            {
                ContextoDTO.Instancia().BomberoSelected.Rut = dataGridResult.SelectedRows[0].Cells["Rut"].Value.ToString();

                if (ContextoDTO.Instancia().BomberoActual.isAdmin)
                {
                    var form = new FichaBombero();
                    form.MdiParent = this.MdiParent;
                    form.Show();
                }
                else
                {
                    var form = new VerFichaBombero();
                    form.MdiParent = this.MdiParent;
                    form.Show();
                }
            }
        }

        private void BuscarBombero_Load(object sender, EventArgs e)
        {

        }
    }
}
