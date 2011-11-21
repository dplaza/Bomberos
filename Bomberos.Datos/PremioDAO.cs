using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class PremioDAO : IPremioDAO
    {
         MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(PremioDTO p_Premio)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO premios (nombre) Values (?p_nombre) ";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_nombre", p_Premio.Nombre);



            try
            {
                conexionBD.Open();
                msqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                throw er;
                //return false;
                //throw new Exception("Problema con base de datos MySQL. Por favor, revise.");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public PremioDTO Load(PremioDTO p_Premio)
        {
            PremioDTO retorno = null;
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM premios WHERE id_premio = ?p_id_premio";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_id_premio", p_Premio.Id);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    retorno = new PremioDTO();

                    retorno.Id = int.Parse(msqlReader["id_premio"].ToString());
                    retorno.Nombre = msqlReader["nombre"].ToString();
                }
            }
            catch (Exception er)
            {
                throw er;
                //throw new Exception("Problema con base de datos MySQL. Por favor, revise.");
            }
            finally
            {
                conexionBD.Close();
            }

            return retorno;
        }

        public bool Delete(PremioDTO p_Premio)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "DELETE FROM premios WHERE id_premio = ?p_id_premio";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_id_premio", p_Premio.Id);

            try
            {
                conexionBD.Open();
                msqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                throw er;
                //return false;
                //throw new Exception("Problema con base de datos MySQL. Por favor, revise.");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public bool Update(PremioDTO p_Premio)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE premios SET id_premio = ?p_id_premio, nombre = ?p_nombre";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_id_premio", p_Premio.Id);
            msqlCommand.Parameters.AddWithValue("?p_nombre", p_Premio.Nombre);
            
            try
            {
                conexionBD.Open();
                msqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                throw er;
                //return false;
                //throw new Exception("Problema con base de datos MySQL. Por favor, revise.");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public List<PremioDTO> LoadAll()
        {
            List<PremioDTO> ListaPremio = new List<PremioDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM premios";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    PremioDTO Premio = new PremioDTO();

                    Premio.Id = int.Parse(msqlReader["id_premio"].ToString());
                    Premio.Nombre = msqlReader["nombre"].ToString();

                    ListaPremio.Add(Premio);
                }
            }
            catch (Exception er)
            {
                throw er;
                //throw new Exception("Problema con base de datos MySQL. Por favor, revise.");
            }
            finally
            {
                conexionBD.Close();
            }
            return ListaPremio;
        }
    }
}
