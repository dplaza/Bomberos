using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class BomberoDAO : IBomberoDAO
    {

        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;   
        }

        public bool Insert(BomberoDTO p_Bombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO bomberos (nombres, apellidos, rut, tib, fecha_inscripcion, fecha_nacimiento, grupo_sanguineo, ";
            query = string.Concat(query, "dir_particular, dir_laboral, tel_particular, tel_laboral, celular, email, profesion, compania, ");
            query = string.Concat(query, "est_civil, is_admin, password) VALUES (?p_nombres, ?p_apellidos, ?p_rut, ?p_tib, ?p_fechainsc, ");
            query = string.Concat(query, "?p_fechanac, ?p_gruposang, ?p_dirpart, ?p_dirlab, ?p_telpart, ?p_tellab, ?p_celular, ?p_email, ");
            query = string.Concat(query, "?p_profesion, ?p_compania, ?p_estcivil, ?p_isadmin, ?p_password) ");         
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_nombres", p_Bombero.Nombres);
            msqlCommand.Parameters.AddWithValue("?p_apellidos", p_Bombero.Apellidos);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_tib", p_Bombero.TIB);
            msqlCommand.Parameters.AddWithValue("?p_fechainsc", p_Bombero.FechaInscripcion);
            msqlCommand.Parameters.AddWithValue("?p_fechanac", p_Bombero.FechaNacimiento);
            msqlCommand.Parameters.AddWithValue("?p_gruposang", p_Bombero.GrupoSanguineo);
            msqlCommand.Parameters.AddWithValue("?p_dirpart", p_Bombero.DireccionParticular);
            msqlCommand.Parameters.AddWithValue("?p_dirlab", p_Bombero.DireccionLaboral);
            msqlCommand.Parameters.AddWithValue("?p_telpart", p_Bombero.TelefonoParticular);
            msqlCommand.Parameters.AddWithValue("?p_tellab", p_Bombero.TelefonoLaboral);
            msqlCommand.Parameters.AddWithValue("?p_celular", p_Bombero.Celular);
            msqlCommand.Parameters.AddWithValue("?p_email", p_Bombero.Email);
            msqlCommand.Parameters.AddWithValue("?p_profesion", p_Bombero.Profesion);
            msqlCommand.Parameters.AddWithValue("?p_compania", p_Bombero.Compañia);
            msqlCommand.Parameters.AddWithValue("?p_estcivil", p_Bombero.EstadoCivil);
            msqlCommand.Parameters.AddWithValue("?p_isadmin", p_Bombero.isAdmin);
            msqlCommand.Parameters.AddWithValue("?p_password", p_Bombero.Password);

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

        public BomberoDTO Load(BomberoDTO p_Bombero)
        {
            BomberoDTO retorno = null;
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM bomberos WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_Bombero.Rut);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    retorno = new BomberoDTO();

                    retorno.Nombres = msqlReader["nombres"].ToString();
                    retorno.Apellidos = msqlReader["apellidos"].ToString();
                    retorno.TIB = msqlReader["tib"].ToString();
                    retorno.FechaInscripcion = DateTime.ParseExact(msqlReader["fecha_inscripcion"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    retorno.FechaNacimiento = DateTime.ParseExact(msqlReader["fecha_nacimiento"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    retorno.DireccionLaboral = msqlReader["dir_laboral"].ToString();
                    retorno.DireccionParticular = msqlReader["dir_particular"].ToString();
                    retorno.TelefonoLaboral = msqlReader["tel_laboral"].ToString();
                    retorno.TelefonoParticular = msqlReader["tel_particular"].ToString();
                    retorno.Celular = msqlReader["celular"].ToString();
                    retorno.Email = msqlReader["email"].ToString();
                    retorno.Profesion = msqlReader["profesion"].ToString();
                    retorno.Compañia = msqlReader["compania"].ToString();
                    retorno.EstadoCivil = msqlReader["est_civil"].ToString();
                    retorno.GrupoSanguineo = msqlReader["grupo_sanguineo"].ToString();
                    retorno.Password = msqlReader["password"].ToString();
                    retorno.Rut = msqlReader["rut"].ToString();
                    retorno.isAdmin = bool.Parse(msqlReader["is_admin"].ToString());
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

        public bool Delete(BomberoDTO p_Bombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "DELETE FROM bomberos WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_Bombero.Rut);

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

        public bool Update(BomberoDTO p_Bombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE bomberos SET nombres = ?p_nombres, apellidos = ?p_apellidos, tib = ?p_tib, ";
            query = string.Concat(query, "fecha_inscripcion = ?p_fechainsc, fecha_nacimiento = ?p_fechanac, grupo_sanguineo = ?p_gruposang, ");
            query = string.Concat(query, "dir_particular = ?p_dirpart, dir_laboral = ?p_dirlab, tel_particular = ?p_telpart, tel_laboral = ?p_tellab, ");
            query = string.Concat(query, "celular = ?p_celular, email = ?p_email, profesion = ?p_profesion, compania = ?p_compania, ");
            query = string.Concat(query, "est_civil = ?p_estcivil, is_admin = ?p_isadmin, password = ?p_password ");
            query = string.Concat(query, "WHERE rut = ?p_rut");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_nombres", p_Bombero.Nombres);
            msqlCommand.Parameters.AddWithValue("?p_apellidos", p_Bombero.Apellidos);
            msqlCommand.Parameters.AddWithValue("?p_tib", p_Bombero.TIB);
            msqlCommand.Parameters.AddWithValue("?p_fechainsc", p_Bombero.FechaInscripcion);
            msqlCommand.Parameters.AddWithValue("?p_fechanac", p_Bombero.FechaNacimiento);
            msqlCommand.Parameters.AddWithValue("?p_gruposang", p_Bombero.GrupoSanguineo);
            msqlCommand.Parameters.AddWithValue("?p_dirpart", p_Bombero.DireccionParticular);
            msqlCommand.Parameters.AddWithValue("?p_dirlab", p_Bombero.DireccionLaboral);
            msqlCommand.Parameters.AddWithValue("?p_telpart", p_Bombero.TelefonoParticular);            
            msqlCommand.Parameters.AddWithValue("?p_tellab", p_Bombero.TelefonoLaboral);
            msqlCommand.Parameters.AddWithValue("?p_celular", p_Bombero.Celular);
            msqlCommand.Parameters.AddWithValue("?p_email", p_Bombero.Email);
            msqlCommand.Parameters.AddWithValue("?p_profesion", p_Bombero.Profesion);
            msqlCommand.Parameters.AddWithValue("?p_compania", p_Bombero.Compañia);
            msqlCommand.Parameters.AddWithValue("?p_estcivil", p_Bombero.EstadoCivil);
            msqlCommand.Parameters.AddWithValue("?p_isadmin", p_Bombero.isAdmin);
            msqlCommand.Parameters.AddWithValue("?p_password", p_Bombero.Password);

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

        public List<BomberoDTO> LoadAll()
        {
            List<BomberoDTO> ListaBomberos = new List<BomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM bomberos";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    BomberoDTO Bombero = new BomberoDTO();

                    Bombero.Nombres = msqlReader["nombres"].ToString();
                    Bombero.Apellidos = msqlReader["apellidos"].ToString();
                    Bombero.TIB = msqlReader["tib"].ToString();
                    Bombero.FechaInscripcion = DateTime.ParseExact(msqlReader["fecha_inscripcion"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    Bombero.FechaNacimiento = DateTime.ParseExact(msqlReader["fecha_nacimiento"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    Bombero.DireccionLaboral = msqlReader["dir_laboral"].ToString();
                    Bombero.DireccionParticular = msqlReader["dir_particular"].ToString();
                    Bombero.TelefonoLaboral = msqlReader["tel_laboral"].ToString();
                    Bombero.TelefonoParticular = msqlReader["tel_particular"].ToString();
                    Bombero.Celular = msqlReader["celular"].ToString();
                    Bombero.Email = msqlReader["email"].ToString();
                    Bombero.Profesion = msqlReader["profesion"].ToString();
                    Bombero.Compañia = msqlReader["compania"].ToString();
                    Bombero.EstadoCivil = msqlReader["est_civil"].ToString();
                    Bombero.GrupoSanguineo = msqlReader["grupo_sanguineo"].ToString();
                    Bombero.Password = msqlReader["password"].ToString();
                    Bombero.Rut = msqlReader["rut"].ToString();
                    Bombero.isAdmin = bool.Parse(msqlReader["is_admin"].ToString());

                    ListaBomberos.Add(Bombero);
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
            return ListaBomberos;
        }
    }
}