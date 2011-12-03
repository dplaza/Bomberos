using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class PremioBomberoDAO : IPremioBomberoDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(PremioBomberoDTO p_PremioBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO premios_bomberos (fecha_califica, rut, id_premio, fecha_entrega) values (?p_fecha_califica, ";
            query = string.Concat(query, "?p_rut, ?p_id_premio, ?p_fecha_entrega)");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_fecha_califica", p_PremioBombero.FechaCalifica);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_PremioBombero.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_id_premio", p_PremioBombero.Premio.Id);
            msqlCommand.Parameters.AddWithValue("?p_fecha_entrega", p_PremioBombero.FechaEntrega);

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

        public List<PremioBomberoDTO> Load(PremioBomberoDTO p_PremioBombero)
        {
            List<PremioBomberoDTO> ListaPremioBombero = new List<PremioBomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM premios_bomberos WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_PremioBombero.Bombero.Rut);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    PremioBomberoDTO PremioBombero = new PremioBomberoDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    IPremioDAO _Premio = new PremioDAO();
                    PremioDTO premio_elem = new PremioDTO();

                    premio_elem.Id = int.Parse(msqlReader["id_premio"].ToString());
                    premio_elem = _Premio.Load(premio_elem);

                    PremioBombero.FechaCalifica = DateTime.ParseExact(msqlReader["fecha_califica"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    PremioBombero.FechaEntrega = DateTime.ParseExact(msqlReader["fecha_entrega"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    PremioBombero.Bombero = bombero_rut;
                    PremioBombero.Premio = premio_elem;
                    PremioBombero.NombrePremio = premio_elem.Nombre;

                    ListaPremioBombero.Add(PremioBombero);
                }
            }
            catch (Exception er)
            {
                return ListaPremioBombero;
            }
            finally
            {
                conexionBD.Close();
            }
            return ListaPremioBombero;
        }

        public bool Delete(PremioBomberoDTO p_PremioBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "DELETE FROM premios_bomberos WHERE rut = ?p_rut AND id_premio = ?p_premio AND fecha_califica = ?p_fecha_califica";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_PremioBombero.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_premio", p_PremioBombero.Premio.Id);
            msqlCommand.Parameters.AddWithValue("?p_fecha_califica", p_PremioBombero.FechaCalifica);

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


        public bool Update(PremioBomberoDTO p_PremioBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE premios_bomberos SET fecha_califica = ?p_fecha_califica, rut = ?p_rut, ";
            query = string.Concat(query, " id_premio = ?p_id_premio, fecha_entrega = ?p_id_fecha_entrega");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_fecha_califica", p_PremioBombero.FechaCalifica);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_PremioBombero.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_id_premio", p_PremioBombero.Premio.Id);
            msqlCommand.Parameters.AddWithValue("?p_fecha_entrega", p_PremioBombero.FechaEntrega);

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

        public List<PremioBomberoDTO> LoadAll()
        {
            List<PremioBomberoDTO> ListaPremioBombero = new List<PremioBomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM premios_bomberos";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    PremioBomberoDTO PremioBombero = new PremioBomberoDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    IPremioDAO _Premio = new PremioDAO();
                    PremioDTO premio_elem = new PremioDTO();

                    premio_elem.Id = int.Parse(msqlReader["id_premio"].ToString());
                    premio_elem = _Premio.Load(premio_elem);

                    PremioBombero.FechaCalifica = DateTime.ParseExact(msqlReader["fecha_califica"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    PremioBombero.FechaEntrega = DateTime.ParseExact(msqlReader["fecha_entrega"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    PremioBombero.Bombero = bombero_rut;
                    PremioBombero.Premio = premio_elem;

                    ListaPremioBombero.Add(PremioBombero);
                }
            }
            catch (Exception er)
            {
                return ListaPremioBombero;
            }
            finally
            {
                conexionBD.Close();
            }
            return ListaPremioBombero;
        }
    }
}

