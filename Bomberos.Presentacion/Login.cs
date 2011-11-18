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
using Bomberos.Presentacion;

namespace Bomberos
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_login_Click(object sender, EventArgs e)
        {
            ILoginMgr login = new LoginMgr();
            BomberoDTO bombero = new BomberoDTO();

            bombero.Rut = txt_user_login.Text;
            bombero.Password = txt_pass_login.Text;
            string tipo = combobox_tipo_login.Text;

            if (login.Autentificacion(bombero, tipo))
            {
                if (tipo.Equals("Administrador"))
                {
                    this.Hide();
                    var form = new MenuAdmin();
                    form.Show();
                }
                else
                {
                    this.Hide();
                    var form = new MenuUsuario();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña erróneo");
                txt_pass_login.ResetText();
                txt_user_login.ResetText();
            }
        }
    }
}
