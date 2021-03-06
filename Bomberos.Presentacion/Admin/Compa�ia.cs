﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomberos.Negocio.Mgr;
using Bomberos.Comun;
using System.IO;

namespace Bomberos.Presentacion
{
    public partial class Compañia : Form
    {
        private string location { get; set; }
        private string fileName { get; set; }

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
                ICompañiaMgr _Compañia = new CompañiaMgr();
                CompañiaDTO Compañia = new CompañiaDTO();

                List<CompañiaDTO> Lista = new List<CompañiaDTO>();
                Lista = _Compañia.ListarCompañias();

                Compañia.Nombre = txt_nombres.Text;

                #region Logo Insignia
                    try
                    {
                        FileStream fs = new FileStream(location, FileMode.Open, FileAccess.Read);

                        Compañia.PictureSizeComp = (int)fs.Length;
                        Compañia.PictureFileComp = new byte[Compañia.PictureSizeComp];
                        fs.Read(Compañia.PictureFileComp, 0, (int)Compañia.PictureSizeComp);
                        Compañia.PictureNameComp = fileName;
                        fs.Close();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Debe elegir una insignia.");
                        return;
                    }
                    #endregion

                if (!Lista.Exists(p => p.Nombre.Equals(Compañia.Nombre)) && _Compañia.RegistroCompañia(Compañia))
                {
                    dataGridResult.DataSource = _Compañia.ListarCompañias().OrderBy(p => p.Nombre).ToList();
                    txt_nombres.Clear();

                }
                else
                {
                    MessageBox.Show("Error al agregar la nueva compañia");
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

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPic = new OpenFileDialog();
            openPic.Title = "Seleccione imagen";
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                box_picture.Image = new Bitmap(openPic.FileName);
                location = openPic.FileName;
                fileName = openPic.SafeFileName;
            }
        }
    }
}
