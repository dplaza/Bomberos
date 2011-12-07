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
    public partial class Cargos : Form
    {
        public Cargos()
        {
            InitializeComponent();
        }

        private void Cargos_Load(object sender, EventArgs e)
        {
            ICargoMgr _Cargo = new CargoMgr();
            dataGridResult.DataSource = _Cargo.ListarCargos().OrderBy(p => p.Nombre).ToList();
            dataGridResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridResult.MultiSelect = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                ICargoMgr _Cargo = new CargoMgr();
                CargoDTO Cargo = new CargoDTO();

                List<CargoDTO> Lista = new List<CargoDTO>();
                Lista = _Cargo.ListarCargos();

                Cargo.Nombre = txt_nombre.Text;

                if (!Lista.Exists(p => p.Nombre.Equals(Cargo.Nombre)) && _Cargo.RegistroCargo(Cargo))
                {
                    dataGridResult.DataSource = _Cargo.ListarCargos().OrderBy(p => p.Nombre).ToList();
                    txt_nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Error al guardar nuevo cargo");
                }
            }
            else
            {
                MessageBox.Show("Falta rellenar datos");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            CargoDTO Cargo = new CargoDTO();
            Cargo.Nombre = dataGridResult.SelectedRows[0].Cells["NombreCargo"].Value.ToString();
            Cargo.Id = int.Parse(dataGridResult.SelectedRows[0].Cells["IdCargo"].Value.ToString());

            MessageBox.Show(Cargo.Id + Cargo.Nombre);
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            ICargoMgr _Cargo = new CargoMgr();
            CargoDTO Cargo = new CargoDTO();

            Cargo.Nombre = dataGridResult.SelectedRows[0].Cells["NombreCargo"].Value.ToString();
            Cargo.Id = int.Parse(dataGridResult.SelectedRows[0].Cells["IdCargo"].Value.ToString());

            if (!_Cargo.BorrarCargo(Cargo))
            {
                MessageBox.Show("Falla al borrar cargo");
            }
            else
            {
                dataGridResult.DataSource = _Cargo.ListarCargos().OrderBy(p => p.Nombre).ToList();
            }
        }

        private void dataGridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
