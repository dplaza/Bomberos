using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class CursoBomberoDAO : ICursoBomberoDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(CursoBomberoDTO p_CursoBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO cursos_bomberos (fecha_inicio, rut, id_curso, fecha_fin, fecha_entrega) values (?p_fecha_inicio, ";
            query = string.Concat(query, "?p_rut, ?p_id_curso, ?p_fecha_fin, ?p_fecha_entrega) ");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_fecha_inicio", p_CursoBombero.FechaInicio);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_CursoBombero.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_id_curso", p_CursoBombero.Curso.Id);
            msqlCommand.Parameters.AddWithValue("?p_fecha_fin", p_CursoBombero.FechaFin);
            msqlCommand.Parameters.AddWithValue("?p_fecha_entrega", p_CursoBombero.FechaEntrega);


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

        public List<CursoBomberoDTO> Load(CursoBomberoDTO p_CursoBombero)
        {
            List<CursoBomberoDTO> ListaCursoBombero = new List<CursoBomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM cursos_bomberos WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_CursoBombero.Bombero.Rut);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    CursoBomberoDTO CursoBombero = new CursoBomberoDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    ICursoDAO _Curso = new CursoDAO();
                    CursoDTO curso_elem = new CursoDTO();

                    curso_elem.Id = int.Parse(msqlReader["id_curso"].ToString());
                    curso_elem = _Curso.Load(curso_elem);

                    CursoBombero.FechaInicio = DateTime.ParseExact(msqlReader["fecha_inicio"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CursoBombero.FechaFin = DateTime.ParseExact(msqlReader["fecha_fin"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CursoBombero.FechaEntrega = DateTime.ParseExact(msqlReader["fecha_entrega"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CursoBombero.Bombero = bombero_rut;
                    CursoBombero.Curso = curso_elem;
                    CursoBombero.NombreCurso = curso_elem.Nombre;

                    ListaCursoBombero.Add(CursoBombero);
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
            return ListaCursoBombero;
        }

        public bool Delete(CursoBomberoDTO p_CursoBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "DELETE FROM cursos_bomberos WHERE rut = ?p_rut AND id_curso = ?p_curso";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_CursoBombero.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_curso", p_CursoBombero.Curso.Id);

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

        public bool Update(CursoBomberoDTO p_CursoBombero)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE cursos_bomberos SET fecha_inicio = ?p_fecha_inicio, rut = ?p_rut, ";
            query = string.Concat(query, " id_curso = ?p_id_curso, fecha_fin = ?p_id_fecha_fin, fecha_entrega = ?p_fecha_entrega");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_fecha_inicio", p_CursoBombero.FechaInicio);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_CursoBombero.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_id_curso", p_CursoBombero.Curso.Id);
            msqlCommand.Parameters.AddWithValue("?p_fecha_fin", p_CursoBombero.FechaFin);
            msqlCommand.Parameters.AddWithValue("?p_fecha_entrega", p_CursoBombero.FechaEntrega);

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

        public List<CursoBomberoDTO> LoadAll()
        {
            List<CursoBomberoDTO> ListaCursoBombero = new List<CursoBomberoDTO>();

            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM cursos_bomberos";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    CursoBomberoDTO CursoBombero = new CursoBomberoDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    ICursoDAO _Curso = new CursoDAO();
                    CursoDTO curso_elem = new CursoDTO();

                    curso_elem.Id = int.Parse(msqlReader["id_curso"].ToString());
                    curso_elem = _Curso.Load(curso_elem);

                    CursoBombero.FechaInicio = DateTime.ParseExact(msqlReader["fecha_inicio"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CursoBombero.FechaFin = DateTime.ParseExact(msqlReader["fecha_fin"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CursoBombero.FechaEntrega = DateTime.ParseExact(msqlReader["fecha_entrega"].ToString(), "dd-MM-yyyy h:mm:ss", null);
                    CursoBombero.Bombero = bombero_rut;
                    CursoBombero.Curso = curso_elem;

                    ListaCursoBombero.Add(CursoBombero);
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
            return ListaCursoBombero;
        }
    }
}
