using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class ReincorporacionBomberoDAO : IReincorporacionBomberoDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

         public bool Insert(ReincorporacionBomberoDTO p_ReincorporacionBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO reincorporaciones_bomberos (rut, fecha_reincorporacion) VALUES (?p_rut, ?p_fecha_reincorporacion)";
             MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
             msqlCommand.Parameters.AddWithValue("?p_rut", p_ReincorporacionBombero.Bombero.Rut);
             msqlCommand.Parameters.AddWithValue("?p_fecha_reincorporacion", p_ReincorporacionBombero.FechaReincorporacion);
         
             
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

         public List<ReincorporacionBomberoDTO> Load(ReincorporacionBomberoDTO p_ReincorporacionBombero)
        {
            List<ReincorporacionBomberoDTO> ListaReincorporacionBombero = new List<ReincorporacionBomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM reincorporaciones_bomberos WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_ReincorporacionBombero.Bombero.Rut);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    ReincorporacionBomberoDTO ReincorporacionBombero = new ReincorporacionBomberoDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    ReincorporacionBombero.Bombero = bombero_rut;
                    ReincorporacionBombero.FechaReincorporacion = DateTime.ParseExact(msqlReader["fecha_reincorporacion"].ToString(), "dd-MM-yyyy h:mm:ss", null);

                    ListaReincorporacionBombero.Add(ReincorporacionBombero);
                }
            }
            catch (Exception er)
            {
                return ListaReincorporacionBombero;
            }
            finally
            {
                conexionBD.Close();
            }
            return ListaReincorporacionBombero;
        }

         public bool Update(ReincorporacionBomberoDTO p_ReincorporacionBombero)
         {
             //MySQL
             MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
             string query = "UPDATE reincorporaciones_bomberos SET rut = ?p_rut, fecha_reincorporacion = ?p_fecha_reincorporacion";
             MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
             msqlCommand.Parameters.AddWithValue("?p_rut", p_ReincorporacionBombero.Bombero.Rut);
             msqlCommand.Parameters.AddWithValue("?p_fecha_reincorporacion", p_ReincorporacionBombero.FechaReincorporacion);

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
