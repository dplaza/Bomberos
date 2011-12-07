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
    public partial class Premios : Form
    {
        public Premios()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Premios_Load(object sender, EventArgs e)
        {
            IPremioMgr _Premio = new PremioMgr();
            dataGridResult.DataSource = _Premio.ListarPremios().OrderBy(p => p.Nombre).ToList();
            dataGridResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridResult.MultiSelect = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombres.Text != "")
            {
                IPremioMgr _Premio = new PremioMgr();
                PremioDTO Premio = new PremioDTO();
               
                List<PremioDTO> Lista  = new List<PremioDTO>();
                Lista = _Premio.ListarPremios();


                Premio.Nombre = txt_nombres.Text;
                if (!Lista.Exists(p => p.Nombre.Equals(Premio.Nombre)) && _Premio.RegistroPremio(Premio))
                {
                    txt_nombres.Clear();
                    dataGridResult.DataSource = _Premio.ListarPremios().OrderBy(p => p.Nombre).ToList();
                }
                else
                {
                    MessageBox.Show("Error al agregar el premio nuevo");
                }
            }
            else
            {
                MessageBox.Show("Falta rellenar datos");
            }
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            IPremioMgr _Premio = new PremioMgr();
            PremioDTO Premio = new PremioDTO();

            Premio.Nombre = dataGridResult.SelectedRows[0].Cells["NombrePremio"].Value.ToString();
            Premio.Id = int.Parse(dataGridResult.SelectedRows[0].Cells["IDPremio"].Value.ToString());

            if (!_Premio.BorrarPremio(Premio))
            {
                MessageBox.Show("Falla al borrar premio");
            }
            else
            {
                dataGridResult.DataSource = _Premio.ListarPremios().OrderBy(p => p.Nombre).ToList();
            }
        }
    }
}
