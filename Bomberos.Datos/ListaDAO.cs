using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class ListaDAO : IListaDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);
            return msqlConnection;
        }

        public bool Insert(ListaDTO p_Lista)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO listas_bomberos (asistencia, rut, canje, faltas, guardias, licencias, llamadas, otras_comp, otros_cuerp, suspensiones, anio, mes) ";
            query = string.Concat(query, "VALUES (?p_asistencia, ?p_rut, ?p_canje, ?p_faltas, ?p_guardias, ?p_licencias, ?p_llamadas, ?p_otrascomp, ?p_otroscuerp, ?p_suspensiones, ?p_anio, ?p_mes)");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_asistencia", p_Lista.Asistencia);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_Lista.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_canje", p_Lista.CompañiasCanje);
            msqlCommand.Parameters.AddWithValue("?p_faltas", p_Lista.Faltas);
            msqlCommand.Parameters.AddWithValue("?p_guardias", p_Lista.GuardiasNocturnas);
            msqlCommand.Parameters.AddWithValue("?p_licencias", p_Lista.Licencias);
            msqlCommand.Parameters.AddWithValue("?p_llamadas", p_Lista.LlamadasComandancia);
            msqlCommand.Parameters.AddWithValue("?p_otrascomp", p_Lista.OtrasCompañias);
            msqlCommand.Parameters.AddWithValue("?p_otroscuerp", p_Lista.OtrosCuerpos);
            msqlCommand.Parameters.AddWithValue("?p_suspensiones", p_Lista.Suspensiones);
            msqlCommand.Parameters.AddWithValue("?p_anio", p_Lista.Año);
            msqlCommand.Parameters.AddWithValue("?p_mes", p_Lista.Mes);

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

        public List<ListaDTO> Load(ListaDTO p_Lista)
        {
            List<ListaDTO> ListaListaBombero = new List<ListaDTO>();
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM listas_bomberos WHERE rut = ?p_rut AND anio = ?p_anio";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_Lista.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_anio", p_Lista.Año);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    IBomberoDAO _Bombero = new BomberoDAO();
                    ListaDTO retorno = new ListaDTO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    retorno.Bombero = bombero_rut;
                    retorno.Asistencia = int.Parse(msqlReader["asistencia"].ToString());
                    retorno.CompañiasCanje = int.Parse(msqlReader["canje"].ToString());
                    retorno.Faltas = int.Parse(msqlReader["faltas"].ToString());
                    retorno.GuardiasNocturnas = int.Parse(msqlReader["guardias"].ToString());
                    retorno.Licencias = int.Parse(msqlReader["licencias"].ToString());
                    retorno.LlamadasComandancia = int.Parse(msqlReader["llamadas"].ToString());
                    retorno.OtrasCompañias = int.Parse(msqlReader["otras_comp"].ToString());
                    retorno.OtrosCuerpos = int.Parse(msqlReader["otros_cuerp"].ToString());
                    retorno.Suspensiones = int.Parse(msqlReader["suspensiones"].ToString());
                    retorno.Mes = int.Parse(msqlReader["mes"].ToString());
                    retorno.Año = int.Parse(msqlReader["anio"].ToString());
                    retorno.TotalAbonos = retorno.LlamadasComandancia + retorno.GuardiasNocturnas + retorno.OtrasCompañias + retorno.OtrosCuerpos + retorno.CompañiasCanje;
                    retorno.TotalLlamadas = retorno.Asistencia + retorno.TotalAbonos;

                    ListaListaBombero.Add(retorno);
                }
            }
            catch (Exception er)
            {
                return ListaListaBombero;
            }
            finally
            {
                conexionBD.Close();
            }
            return ListaListaBombero;
        }

        public bool Update(ListaDTO p_Lista)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE listas_bomberos SET asistencia = ?p_asistencia, rut = ?p_rut, canje = ?p_canje, faltas = ?p_faltas, guardias = ?p_guardias, licencias = ?p_licencias, llamadas = ?p_llamadas, otras_comp = ?p_otrascomp, otros_cuerp = ?p_otroscuerp, suspensiones = ?p_suspensiones ";
            query = string.Concat(query, "WHERE rut = ?p_rut AND anio = ?p_anio AND mes = ?p_mes");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_asistencia", p_Lista.Asistencia);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_Lista.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_canje", p_Lista.CompañiasCanje);
            msqlCommand.Parameters.AddWithValue("?p_faltas", p_Lista.Faltas);
            msqlCommand.Parameters.AddWithValue("?p_guardias", p_Lista.GuardiasNocturnas);
            msqlCommand.Parameters.AddWithValue("?p_licencias", p_Lista.Licencias);
            msqlCommand.Parameters.AddWithValue("?p_llamadas", p_Lista.LlamadasComandancia);
            msqlCommand.Parameters.AddWithValue("?p_otrascomp", p_Lista.OtrasCompañias);
            msqlCommand.Parameters.AddWithValue("?p_otroscuerp", p_Lista.OtrosCuerpos);
            msqlCommand.Parameters.AddWithValue("?p_suspensiones", p_Lista.Suspensiones);
            msqlCommand.Parameters.AddWithValue("?p_anio", p_Lista.Año);
            msqlCommand.Parameters.AddWithValue("?p_mes", p_Lista.Mes);

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
