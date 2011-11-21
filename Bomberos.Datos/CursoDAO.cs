using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class CursoDAO : ICursoDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(CursoDTO p_Curso)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO cursos (nombre) Values (?p_nombre) ";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_nombre", p_Curso.Nombre);



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

        public CursoDTO Load(CursoDTO p_Curso)
        {
            CursoDTO retorno = null;
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM cursos WHERE id_curso = ?p_id_curso";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_id_curso", p_Curso.Id);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    retorno = new CursoDTO();

                    retorno.Id = int.Parse(msqlReader["id_curso"].ToString());
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

        public bool Delete(CursoDTO p_Curso)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "DELETE FROM cursos WHERE id_curso = ?p_id_curso";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_id_curso", p_Curso.Id);

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

        public bool Update(CursoDTO p_Curso)
        {
             //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE cursos SET id_curso = ?p_id_curso, nombre = ?p_nombre";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_id_curso", p_Curso.Id);
            msqlCommand.Parameters.AddWithValue("?p_nombre", p_Curso.Nombre);
            
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
        
        

        public List<CursoDTO> LoadAll()
        {
            List<CursoDTO> ListaCurso = new List<CursoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM cursos";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    CursoDTO Curso = new CursoDTO();

                    Curso.Id = int.Parse(msqlReader["id_curso"].ToString());
                    Curso.Nombre = msqlReader["nombre"].ToString();

                    ListaCurso.Add(Curso);
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
            return ListaCurso;
        }
    }
}
