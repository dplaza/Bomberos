using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class ServicioBomberoDAO : IServicioBomberoDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(ServicioBomberoDTO p_ServicioBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO servicios_bomberos (anio, anio_servicio, mes_servicio, dia_servicio, llamadas, faltas, suspensiones, ";
            query = string.Concat(query, "licencias, abonos, rut) VALUES (?p_anio, ?p_anio_servicio, ?p_mes_servicio, ?p_dia_servicio, ?p_llamadas, ");
            query = string.Concat(query, "?p_faltas, ?p_suspensiones, ?p_licencias, ?p_abonos, ?p_rut)");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_anio", p_ServicioBombero.Año);
            msqlCommand.Parameters.AddWithValue("?p_anio_servicio", p_ServicioBombero.AñoServicio);
            msqlCommand.Parameters.AddWithValue("?p_mes_servicio", p_ServicioBombero.MesServicio);
            msqlCommand.Parameters.AddWithValue("?p_dia_servicio", p_ServicioBombero.DiaServicio);
            msqlCommand.Parameters.AddWithValue("?p_llamadas", p_ServicioBombero.Llamadas);
            msqlCommand.Parameters.AddWithValue("?p_faltas", p_ServicioBombero.Faltas);
            msqlCommand.Parameters.AddWithValue("?p_suspensiones", p_ServicioBombero.Suspensiones);
            msqlCommand.Parameters.AddWithValue("?p_licencias", p_ServicioBombero.Licencias);
            msqlCommand.Parameters.AddWithValue("?p_abonos", p_ServicioBombero.Abonos);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_ServicioBombero.Bombero.Rut);

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

        public List<ServicioBomberoDTO> Load(ServicioBomberoDTO p_ServicioBombero)
        {
            List<ServicioBomberoDTO> ListaServicioBombero = new List<ServicioBomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM servicios_bomberos WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_ServicioBombero.Bombero.Rut);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    ServicioBomberoDTO ServicioBombero = new ServicioBomberoDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);


                    ServicioBombero.Año = int.Parse(msqlReader["anio"].ToString());
                    ServicioBombero.AñoServicio = int.Parse(msqlReader["anio_servicio"].ToString());
                    ServicioBombero.MesServicio = int.Parse(msqlReader["mes_servicio"].ToString());
                    ServicioBombero.DiaServicio = int.Parse(msqlReader["dia_servicio"].ToString());
                    ServicioBombero.Bombero = bombero_rut;
                    ServicioBombero.Llamadas = int.Parse(msqlReader["llamadas"].ToString());
                    ServicioBombero.Licencias = int.Parse(msqlReader["licencias"].ToString());
                    ServicioBombero.Faltas = int.Parse(msqlReader["faltas"].ToString());
                    ServicioBombero.Suspensiones = int.Parse(msqlReader["suspensiones"].ToString());
                    ServicioBombero.Abonos = int.Parse(msqlReader["abonos"].ToString());
                    ServicioBombero.Asistencia = int.Parse(msqlReader["llamadas"].ToString());
                    ServicioBombero.TotalAsistencia = ServicioBombero.Llamadas + ServicioBombero.Abonos;

                    ListaServicioBombero.Add(ServicioBombero);
                }
            }
            catch (Exception er)
            {
                return ListaServicioBombero;
            }
            finally
            {
                conexionBD.Close();
            }
            return ListaServicioBombero;
        }

        public bool Update(ServicioBomberoDTO p_ServicioBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE servicios_bomberos SET anio_servicio = ?p_anio_servicio, ";
            query = string.Concat(query, "mes_servicio = ?p_mes_servicio, dia_servicio = ?p_dia_servicio, llamadas = ?p_llamadas, ");
            query = string.Concat(query, "faltas = ?p_faltas, suspensiones = ?p_suspensiones, licencias = ?p_licencias, abonos = ?p_abonos WHERE rut = ?p_rut AND anio = ?p_anio");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_anio", p_ServicioBombero.Año);
            msqlCommand.Parameters.AddWithValue("?p_anio_servicio", p_ServicioBombero.AñoServicio);
            msqlCommand.Parameters.AddWithValue("?p_mes_servicio", p_ServicioBombero.MesServicio);
            msqlCommand.Parameters.AddWithValue("?p_dia_servicio", p_ServicioBombero.DiaServicio);
            msqlCommand.Parameters.AddWithValue("?p_llamadas", p_ServicioBombero.Llamadas);
            msqlCommand.Parameters.AddWithValue("?p_faltas", p_ServicioBombero.Faltas);
            msqlCommand.Parameters.AddWithValue("?p_suspensiones", p_ServicioBombero.Suspensiones);
            msqlCommand.Parameters.AddWithValue("?p_licencias", p_ServicioBombero.Licencias);
            msqlCommand.Parameters.AddWithValue("?p_abonos", p_ServicioBombero.Abonos);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_ServicioBombero.Bombero.Rut);

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
    }
}
