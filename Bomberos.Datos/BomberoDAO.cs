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

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("INSERT INTO ");
            strBuilder.Append("bomberos (nombres, apellidos, rut, tib, fecha_inscripcion, fecha_nacimiento, grupo_sanguineo, ");
            strBuilder.Append("dir_particular, dir_laboral, tel_particular, tel_laboral, celular, email, profesion, compania, ");
            strBuilder.Append("est_civil, is_admin, password, estado, cargo, id_socio, picture_name, picture_size, picture_file) ");
            strBuilder.Append("VALUES (?p_nombres, ?p_apellidos, ?p_rut, ?p_tib, ?p_fechainsc, ?p_fechanac, ?p_gruposang, ?p_dirpart, ");
            strBuilder.Append("?p_dirlab, ?p_telpart, ?p_tellab, ?p_celular, ?p_email, ?p_profesion, ?p_compania, ?p_estcivil, ?p_isadmin, ");
            strBuilder.Append("?p_password, ?p_estado, ?p_cargo, ?p_socio, ?p_picname, ?p_picsize, ?p_picfile)");
            string query = strBuilder.ToString();

            #region Parametros Query
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
            msqlCommand.Parameters.AddWithValue("?p_compania", p_Bombero.Compañia.Id);
            msqlCommand.Parameters.AddWithValue("?p_estcivil", p_Bombero.EstadoCivil);
            msqlCommand.Parameters.AddWithValue("?p_isadmin", p_Bombero.isAdmin);
            msqlCommand.Parameters.AddWithValue("?p_password", p_Bombero.Password);
            msqlCommand.Parameters.AddWithValue("?p_estado", p_Bombero.Estado);
            msqlCommand.Parameters.AddWithValue("?p_cargo", p_Bombero.Cargo.Id);
            msqlCommand.Parameters.AddWithValue("?p_socio", p_Bombero.NumeroRegistro);
            msqlCommand.Parameters.AddWithValue("?p_picname", p_Bombero.PictureName);
            msqlCommand.Parameters.AddWithValue("?p_picsize", p_Bombero.PictureSize);
            msqlCommand.Parameters.AddWithValue("?p_picfile", p_Bombero.PictureFile);
            #endregion

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
                    ICompañiaDAO _Compañia = new CompañiaDAO();
                    CompañiaDTO compañia_elem = new CompañiaDTO();

                    compañia_elem.Id = int.Parse(msqlReader["compania"].ToString());
                    compañia_elem = _Compañia.Load(compañia_elem);

                    ICargoDAO _Cargo = new CargoDAO();
                    CargoDTO cargo_elem = new CargoDTO();

                    cargo_elem.Id = int.Parse(msqlReader["cargo"].ToString());
                    cargo_elem = _Cargo.Load(cargo_elem);

                    #region Asignacion Campos
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
                    retorno.Compañia = compañia_elem;
                    retorno.EstadoCivil = msqlReader["est_civil"].ToString();
                    retorno.GrupoSanguineo = msqlReader["grupo_sanguineo"].ToString();
                    retorno.Password = msqlReader["password"].ToString();
                    retorno.Rut = msqlReader["rut"].ToString();
                    retorno.isAdmin = bool.Parse(msqlReader["is_admin"].ToString());
                    retorno.Cargo = cargo_elem;
                    retorno.Estado = msqlReader["estado"].ToString();
                    retorno.NumeroRegistro = int.Parse(msqlReader["id_socio"].ToString());
                    retorno.PictureName = msqlReader.GetString(msqlReader.GetOrdinal("picture_name"));
                    retorno.PictureSize = msqlReader.GetInt32(msqlReader.GetOrdinal("picture_size"));
                    retorno.PictureFile = new byte[retorno.PictureSize];
                    msqlReader.GetBytes(msqlReader.GetOrdinal("picture_file"), 0, retorno.PictureFile, 0, retorno.PictureSize);
                    #endregion
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
                return false;
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

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("UPDATE bomberos SET nombres = ?p_nombres, apellidos = ?p_apellidos, tib = ?p_tib, fecha_inscripcion = ?p_fechainsc, ");
            strBuilder.Append("fecha_nacimiento = ?p_fechanac, grupo_sanguineo = ?p_gruposang, dir_particular = ?p_dirpart, dir_laboral = ?p_dirlab, ");
            strBuilder.Append("tel_particular = ?p_telpart, tel_laboral = ?p_tellab, celular = ?p_celular, email = ?p_email, profesion = ?p_profesion, ");
            strBuilder.Append("compania = ?p_compania, id_socio = ?p_socio, est_civil = ?p_estcivil, is_admin = ?p_isadmin, password = ?p_password, ");
            strBuilder.Append("cargo = ?p_cargo, estado = ?p_estado, picture_name = ?p_picname, picture_size = ?p_picsize, picture_file = ?p_picfile ");
            strBuilder.Append("WHERE rut = ?p_rut");

            string query = strBuilder.ToString();

            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);

            #region Parametros Query
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
            msqlCommand.Parameters.AddWithValue("?p_compania", p_Bombero.Compañia.Id);
            msqlCommand.Parameters.AddWithValue("?p_estcivil", p_Bombero.EstadoCivil);
            msqlCommand.Parameters.AddWithValue("?p_isadmin", p_Bombero.isAdmin);
            msqlCommand.Parameters.AddWithValue("?p_password", p_Bombero.Password);
            msqlCommand.Parameters.AddWithValue("?p_estado", p_Bombero.Estado);
            msqlCommand.Parameters.AddWithValue("?p_cargo", p_Bombero.Cargo.Id);
            msqlCommand.Parameters.AddWithValue("?p_socio", p_Bombero.NumeroRegistro);
            msqlCommand.Parameters.AddWithValue("?p_picname", p_Bombero.PictureName);
            msqlCommand.Parameters.AddWithValue("?p_picsize", p_Bombero.PictureSize);
            msqlCommand.Parameters.AddWithValue("?p_picfile", p_Bombero.PictureFile);
            #endregion

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

                    ICompañiaDAO _Compañia = new CompañiaDAO();
                    CompañiaDTO compañia_elem = new CompañiaDTO();

                    compañia_elem.Id = int.Parse(msqlReader["compania"].ToString());
                    compañia_elem = _Compañia.Load(compañia_elem);

                    ICargoDAO _Cargo = new CargoDAO();
                    CargoDTO cargo_elem = new CargoDTO();

                    cargo_elem.Id = int.Parse(msqlReader["cargo"].ToString());
                    cargo_elem = _Cargo.Load(cargo_elem);

                    #region Asignacion campos
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
                    Bombero.Compañia = compañia_elem;
                    Bombero.EstadoCivil = msqlReader["est_civil"].ToString();
                    Bombero.GrupoSanguineo = msqlReader["grupo_sanguineo"].ToString();
                    Bombero.Password = msqlReader["password"].ToString();
                    Bombero.Rut = msqlReader["rut"].ToString();
                    Bombero.isAdmin = bool.Parse(msqlReader["is_admin"].ToString());
                    Bombero.Cargo = cargo_elem;
                    Bombero.Estado = msqlReader["estado"].ToString();
                    Bombero.NumeroRegistro = int.Parse(msqlReader["id_socio"].ToString());
                    Bombero.PictureName = msqlReader.GetString(msqlReader.GetOrdinal("picture_name"));
                    Bombero.PictureSize = msqlReader.GetInt32(msqlReader.GetOrdinal("picture_size"));
                    Bombero.PictureFile = new byte[Bombero.PictureSize];
                    #endregion

                    try
                    {
                        msqlReader.GetBytes(msqlReader.GetOrdinal("picture_file"), 0, Bombero.PictureFile, 0, Bombero.PictureSize);
                    }
                    catch (Exception er) { }
                    ListaBomberos.Add(Bombero);
                }
            }
            catch (Exception er)
            {
                return ListaBomberos;
            }
            finally
            {
                conexionBD.Close();
            }
            return ListaBomberos;
        }
    }
}