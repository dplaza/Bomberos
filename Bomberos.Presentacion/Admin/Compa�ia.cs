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
    public partial class Compañia : Form
    {
        public Compañia()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Compañia_Load(object sender, EventArgs e)
        {
            ICompañiaMgr _Compañia = new CompañiaMgr();
            dataGridResult.DataSource = _Compañia.ListarCompañias().OrderBy(p => p.Nombre).ToList();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombres.Text != "")
            {
                ICompañiaMgr _Compañia = new CompañiaMgr();
                CompañiaDTO Compañia = new CompañiaDTO();

                Compañia.Nombre = txt_nombres.Text;
                if (_Compañia.RegistroCompañia(Compañia))
                {
                    dataGridResult.DataSource = _Compañia.ListarCompañias().OrderBy(p => p.Nombre).ToList();
                    txt_nombres.Clear();
                }
            }
            else
            {
                MessageBox.Show("Falta rellenar datos");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            ICompañiaMgr _Compañia = new CompañiaMgr();
            CompañiaDTO Compañia = new CompañiaDTO();

            Compañia.Nombre = dataGridResult.SelectedRows[0].Cells["NombreCompañia"].Value.ToString();
            Compañia.Id = int.Parse(dataGridResult.SelectedRows[0].Cells["idCompañia"].Value.ToString());

            if (!_Compañia.BorrarCompañia(Compañia))
            {
                MessageBox.Show("Falla al borrar compañia");
            }
            else
            {
                dataGridResult.DataSource = _Compañia.ListarCompañias().OrderBy(p => p.Nombre).ToList();
            }
        }
    }
}
