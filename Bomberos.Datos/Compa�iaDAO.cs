using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class CompañiaDAO : ICompañiaDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=192.168.20.5; uid=sistema_bomberos; pwd=9qpbVRl; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(CompañiaDTO p_Compañia)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO companias (nombre, picture_name, picture_size, picture_file) Values (?p_nombre, ?p_picture_name, ?p_picture_size, ?p_picture_file) ";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_nombre", p_Compañia.Nombre);
            msqlCommand.Parameters.AddWithValue("?p_picture_name", p_Compañia.PictureNameComp);
            msqlCommand.Parameters.AddWithValue("p_picture_size", p_Compañia.PictureSizeComp);
            msqlCommand.Parameters.AddWithValue("p_picture_file", p_Compañia.PictureFileComp);

           
            
            try
            {
                conexionBD.Open();
                msqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                return false;
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public CompañiaDTO Load(CompañiaDTO p_Compañia)
        {
            CompañiaDTO retorno = null;
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM companias WHERE id_compania = ?p_compania";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_compania", p_Compañia.Id);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    retorno = new CompañiaDTO();

                    retorno.Id = int.Parse(msqlReader["id_compania"].ToString());
                    retorno.Nombre = msqlReader["nombre"].ToString();
                    retorno.PictureNameComp = msqlReader.GetString(msqlReader.GetOrdinal("picture_name"));
                    retorno.PictureFileComp = msqlReader.GetInt32(msqlReader.GetOrdinal("picture_size"));
                    retorno.PictureFileComp = new byte[retorno.PictureSizeComp];
                    msqlReader.GetBytes(msqlReader.GetOrdinal("picture_file"), 0, retorno.PictureFileComp, 0, retorno.PictureSizeComp);
                }
            }
            catch (Exception er)
            {
                return retorno;
            }
            finally
            {
                conexionBD.Close();
            }

            return retorno;
        }

        public bool Delete(CompañiaDTO p_Compañia)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "DELETE FROM companias WHERE id_compania = ?p_id_compania";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_id_compania", p_Compañia.Id);

            try
            {
                conexionBD.Open();
                msqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                return false;
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public bool Update(CompañiaDTO p_Compañia)
        {
             //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE compania SET id_compania = ?p_id_compania, nombre = ?p_nombre, picture_name = ?p_picname, picture_file = ?p_picfile, picture_size = ?p_picsize";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_id_compania", p_Compañia.Id);
            msqlCommand.Parameters.AddWithValue("?p_nombre", p_Compañia.Nombre);
            msqlCommand.Parameters.AddWithValue("?p_picname", p_Compañia.PictureNameComp);
            msqlCommand.Parameters.AddWithValue("?p_picsize", p_Compañia.PictureSizeComp);
            msqlCommand.Parameters.AddWithValue("?p_picfile", p_Compañia.PictureFileComp);
            
            try
            {
                conexionBD.Open();
                msqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                return false;
            }
            finally
            {
                conexionBD.Close();
            }
        }
        

        public List<CompañiaDTO> LoadAll()
        {
            List<CompañiaDTO> ListaCompañia = new List<CompañiaDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM companias";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    CompañiaDTO Compañia = new CompañiaDTO();

                    Compañia.Id = int.Parse(msqlReader["id_compania"].ToString());
                    Compañia.Nombre= msqlReader["nombre"].ToString();
                    Compañia.PictureNameComp = msqlReader.GetString(msqlReader.GetOrdinal("picture_name"));
                    Compañia.PictureSizeComp = msqlReader.GetInt32(msqlReader.GetOrdinal("picture_size"));
                    Compañia.PictureFileComp = new byte[Compañia.PictureFileComp];

                    ListaCompañia.Add(Compañia);
                }
            }
            catch (Exception er)
            {
                return ListaCompañia;
            }
            finally
            {
                conexionBD.Close();
            }
            return ListaCompañia;

        }
    }
}