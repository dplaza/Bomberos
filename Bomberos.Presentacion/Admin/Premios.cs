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
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                IPremioMgr _Premio = new PremioMgr();
                PremioDTO Premio = new PremioDTO();

                Premio.Nombre = txt_nombres.Text;
                if (_Premio.RegistroPremio(Premio))
                {
                    txt_nombres.Clear();
                    dataGridResult.DataSource = _Premio.ListarPremios().OrderBy(p => p.Nombre).ToList();
                }
            }
            else
            {
                MessageBox.Show("Falta rellenar datos");
            }
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {

        }
    }
}
