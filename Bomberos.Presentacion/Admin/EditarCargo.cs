using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomberos.Comun;
using Bomberos.Negocio.Mgr;

namespace Bomberos.Presentacion.Admin
{
    public partial class EditarCargo : Form
    {
        private CargoDTO CargoActual { get; set; }

        public EditarCargo()
        {
            CargoActual = new CargoDTO();
            InitializeComponent();
        }

        private void EditarCargo_Load(object sender, EventArgs e)
        {
            txt_cargo.Text = CargoActual.Nombre;
        }

        public void InicializaInfoCargo(CargoDTO p_Cargo)
        {
            this.CargoActual = p_Cargo;
            this.Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_cargo.Text != "")
            {
                ICargoMgr _Cargo = new CargoMgr();

                CargoActual.Nombre = txt_cargo.Text;
                if (_Cargo.EditarCargo(CargoActual))
                {
                    MessageBox.Show("Cambio exitoso!");
                    this.MdiParent.Refresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al enviar cambios.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para el cargo.");
            }
        }
    }
}
