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

            CargoDTO cargo = new CargoDTO();
            cargo = (CargoDTO)select_cargo.SelectedItem;

            if (cargo.Id != 0)
            {
                dataGridResult.DataSource = _Bombero.ListarBomberos().FindAll(p => p.Cargo.Id.Equals(cargo.Id) && p.Nombres.Contains(txt_nombres.Text) && p.Apellidos.Contains(txt_apellidos.Text) && p.Rut.Contains(txt_rut.Text) && p.TIB.Contains(txt_tib.Text)).OrderBy(p => p.Nombres).ToList();
            }
            else
            {
                dataGridResult.DataSource = _Bombero.ListarBomberos().FindAll(p => p.Nombres.Contains(txt_nombres.Text) && p.Apellidos.Contains(txt_apellidos.Text) && p.Rut.Contains(txt_rut.Text) && p.TIB.Contains(txt_tib.Text)).OrderBy(p => p.Nombres).ToList();
            }
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

                var form = new FichaBombero();
                form.MdiParent = this.MdiParent;
                form.Show();

            }
        }

        private void BuscarBombero_Load(object sender, EventArgs e)
        {
            ICargoMgr _Cargo = new CargoMgr();
            CargoDTO cargo_null = new CargoDTO();
            cargo_null.Id = 0;
            cargo_null.Nombre = "-----";
            List<CargoDTO> lista = new List<CargoDTO>();
            lista = _Cargo.ListarCargos();
            lista.Add(cargo_null);
            select_cargo.DataSource = lista.OrderBy(p => p.Nombre).ToList();
            select_cargo.DisplayMember = "Nombre";
            select_cargo.ValueMember = "Id";
        }
    }
}
