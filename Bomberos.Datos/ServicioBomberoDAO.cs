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
            query = string.Concat(query, "licencias, abonos) VALUES (?p_anio, ?p_anio_servicio, ?p_mes_servicio, ?p_dia_servicio, ?p_llamadas, ");
            query = string.Concat(query, "?p_faltas, ?p_suspensiones)" );
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_anio",p_ServicioBombero.Año);
            msqlCommand.Parameters.AddWithValue("?p_anio_servicio", p_ServicioBombero.AñoServicio);
            msqlCommand.Parameters.AddWithValue("?p_mes_servicio", p_ServicioBombero.MesServicio);
            msqlCommand.Parameters.AddWithValue("?p_dia_servicio", p_ServicioBombero.DiaServicio);
            msqlCommand.Parameters.AddWithValue("?p_llamadas", p_ServicioBombero.Llamadas);
            msqlCommand.Parameters.AddWithValue("?p_faltas", p_ServicioBombero.Faltas);
            msqlCommand.Parameters.AddWithValue("?p_suspensiones", p_ServicioBombero.Suspenciones);
            msqlCommand.Parameters.AddWithValue("?p_licencias",p_ServicioBombero.Licencias);
            msqlCommand.Parameters.AddWithValue("?p_abonos", p_ServicioBombero.Abonos);


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


    }
}
