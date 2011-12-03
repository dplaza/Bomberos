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
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(CompañiaDTO p_Compañia)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO companias (nombre) Values (?p_nombre) ";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_nombre", p_Compañia.Nombre);

           
            
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
            string query = "UPDATE compania SET id_compania = ?p_id_compania, nombre = ?p_nombre";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_id_compania", p_Compañia.Id);
            msqlCommand.Parameters.AddWithValue("?p_nombre", p_Compañia.Nombre);
            
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