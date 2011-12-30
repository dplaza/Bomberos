using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class ObservacionBomberoDAO : IObservacionBomberoDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=192.168.20.5; uid=sistema_bomberos; pwd=9qpbVRl; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(ObservacionBomberoDTO p_ObservacionBombero)
        {

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO observaciones_bomberos (rut, fecha, observacion) values (?p_rut, ?p_fecha, ?p_observacion)";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_ObservacionBombero.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_fecha", p_ObservacionBombero.Fecha);
            msqlCommand.Parameters.AddWithValue("?p_observacion", p_ObservacionBombero.Observacion);

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

        public List<ObservacionBomberoDTO> Load(ObservacionBomberoDTO p_ObservacionBombero)
        {
            List<ObservacionBomberoDTO> ListaObservacionBombero = new List<ObservacionBomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM observaciones_bomberos WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_ObservacionBombero.Bombero.Rut);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    ObservacionBomberoDTO ObservacionBombero = new ObservacionBomberoDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    ObservacionBombero.Bombero = bombero_rut;
                    ObservacionBombero.Fecha = DateTime.ParseExact(msqlReader["fecha"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    ObservacionBombero.Observacion = msqlReader["observacion"].ToString();

                    ListaObservacionBombero.Add(ObservacionBombero);
                }
            }
            catch (Exception er)
            {
                return ListaObservacionBombero;
            }
            finally
            {
                conexionBD.Close();
            }
            return ListaObservacionBombero;
        }
    }
}
