using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomberos.Negocio.Mgr;

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
            CargoMgr _Cargo = new CargoMgr();
            dataGridResult.DataSource = _Cargo.ListarCargos();
        }
    }
}
