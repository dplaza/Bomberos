using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class CargoBomberoDAO : ICargoBomberoDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(CargoBomberoDTO p_CargoBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO cargos_bomberos (fecha_desde, rut, id_cargo, fecha_hasta) values (?p_fecha_desde, ";
            query = string.Concat(query, "?p_rut, ?p_id_cargo, ?p_fecha_hasta) ");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_fecha_desde", p_CargoBombero.FechaDesde);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_CargoBombero.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_id_cargo", p_CargoBombero.Cargo.Id);
            msqlCommand.Parameters.AddWithValue("?p_fecha_hasta", p_CargoBombero.FechaHasta);



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

        public List<CargoBomberoDTO> Load(CargoBomberoDTO p_CargoBombero)
        {
            List<CargoBomberoDTO> ListaCargoBombero = new List<CargoBomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM cargos_bomberos WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_CargoBombero.Bombero.Rut);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    CargoBomberoDTO CargoBombero = new CargoBomberoDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    ICargoDAO _Cargo = new CargoDAO();
                    CargoDTO cargo_elem = new CargoDTO();

                    cargo_elem.Id = int.Parse(msqlReader["id_cargo"].ToString());
                    cargo_elem = _Cargo.Load(cargo_elem);

                    CargoBombero.FechaDesde = DateTime.ParseExact(msqlReader["fecha_desde"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CargoBombero.FechaHasta = DateTime.ParseExact(msqlReader["fecha_hasta"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CargoBombero.Bombero = bombero_rut;
                    CargoBombero.Cargo = cargo_elem;
                    CargoBombero.NombreCargo = cargo_elem.Nombre;

                    ListaCargoBombero.Add(CargoBombero);
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
            return ListaCargoBombero;
        }

        public bool Delete(CargoBomberoDTO p_CargoBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "DELETE FROM cargos_bomberos WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_CargoBombero.Bombero.Rut);

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

        public bool Update(CargoBomberoDTO p_CargoBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE cargos_bomberos SET fecha_desde = ?p_fecha_desde, rut = ?p_rut, ";
            query = string.Concat(query, " id_cargo = ?p_id_cargo, fecha_hasta = ?p_id_fecha_hasta");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_fecha_desde", p_CargoBombero.FechaDesde);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_CargoBombero.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_id_cargo", p_CargoBombero.Cargo.Id);
            msqlCommand.Parameters.AddWithValue("?p_fecha_hasta", p_CargoBombero.FechaHasta);

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

        public List<CargoBomberoDTO> LoadAll()
        {
            List<CargoBomberoDTO> ListaCargoBombero = new List<CargoBomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM cargos_bomberos";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    CargoBomberoDTO CargoBombero = new CargoBomberoDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    ICargoDAO _Cargo = new CargoDAO();
                    CargoDTO cargo_elem = new CargoDTO();

                    cargo_elem.Id = int.Parse(msqlReader["id_cargo"].ToString());
                    cargo_elem = _Cargo.Load(cargo_elem);

                    CargoBombero.FechaDesde = DateTime.ParseExact(msqlReader["fecha_desde"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CargoBombero.FechaHasta = DateTime.ParseExact(msqlReader["fecha_hasta"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CargoBombero.Bombero = bombero_rut;
                    CargoBombero.Cargo = cargo_elem;

                    ListaCargoBombero.Add(CargoBombero);
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
            return ListaCargoBombero;
        }
    }
}
