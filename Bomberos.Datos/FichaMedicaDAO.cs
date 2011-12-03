using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class FichaMedicaDAO : IFichaMedicaDAO
    {
        MySql.Data.MySqlClient.MySqlConnection ConnectBD()
        {
            string parameters = "server=localhost; user id=root; Password=nomeweis; database=bomberos; persist security info=False";
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(parameters);

            return msqlConnection;
        }

        public bool Insert(FichaMedicaDTO p_FichaMedica)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "INSERT INTO fichas_medicas (rut, hepatitis, tifus, otras_enfermedades, operaciones, ";
            query = string.Concat(query, "hipertension_arterial, diabetes, epilepsia, asma, antecedentes_cronicos, ");
            query = string.Concat(query, "medicamentos_toma, medicamentos_no_toma, nombre_pariente_1, parentesco_pariente_1,");
            query = string.Concat(query, "telefono_pariente_1, celular_pariente_1, nombre_pariente_2, parentesco_pariente_2,"); 
            query = string.Concat(query, "telefono_pariente_2, celular_pariente_2) VALUES (?p_rut,?p_hepatitis,?p_tifus, ");
            query = string.Concat(query, "?p_otras_enfermedades,?p_operaciones,?p_hipertension_arterial,?p_diabetes, ");
            query = string.Concat(query, "?p_epilepsia,?p_asma,?p_antecedentes_cronicos,?p_medicamentos_toma, ?p_medicamentos_no_toma,");
            query = string.Concat(query, "?p_nombre_pariente_1, ?p_parentesco_pariente_1, ?p_telefono_pariente_1, ?p_celular_pariente_1,");
            query = string.Concat(query, "?p_nombre_pariente_2, ?p_parentesco_pariente_2, ?p_telefono_pariente_2, ?p_celular_pariente_2)");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_FichaMedica.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_hepatitis", p_FichaMedica.Hepatitis);
            msqlCommand.Parameters.AddWithValue("?p_tifus", p_FichaMedica.Tifus);
            msqlCommand.Parameters.AddWithValue("?p_otras_enfermedades", p_FichaMedica.OtrasEnfermedades);
            msqlCommand.Parameters.AddWithValue("?p_operaciones", p_FichaMedica.Operaciones);
            msqlCommand.Parameters.AddWithValue("?p_hipertension_arterial", p_FichaMedica.HipertensionArterial);
            msqlCommand.Parameters.AddWithValue("?p_diabetes", p_FichaMedica.Diabetes);
            msqlCommand.Parameters.AddWithValue("?p_epilepsia", p_FichaMedica.Epilepsia);
            msqlCommand.Parameters.AddWithValue("?p_asma", p_FichaMedica.Asma);
            msqlCommand.Parameters.AddWithValue("?p_antecedentes_cronicos", p_FichaMedica.AntecedentesCronicos);
            msqlCommand.Parameters.AddWithValue("?p_medicamentos_toma", p_FichaMedica.MedicamentosToma);
            msqlCommand.Parameters.AddWithValue("?p_medicamentos_no_toma", p_FichaMedica.MedicamentosNoToma);
            msqlCommand.Parameters.AddWithValue("?p_nombre_pariente_1", p_FichaMedica.NombrePariente1);
            msqlCommand.Parameters.AddWithValue("?p_parentesco_pariente_1", p_FichaMedica.ParentescoPariente1);
            msqlCommand.Parameters.AddWithValue("?p_telefono_pariente_1", p_FichaMedica.TelefonoPariente1);
            msqlCommand.Parameters.AddWithValue("?p_celular_pariente_1", p_FichaMedica.CelularPariente1);
            msqlCommand.Parameters.AddWithValue("?p_nombre_pariente_2", p_FichaMedica.NombrePariente2);
            msqlCommand.Parameters.AddWithValue("?p_parentesco_pariente_2", p_FichaMedica.ParentescoPariente2);
            msqlCommand.Parameters.AddWithValue("?p_telefono_pariente_2", p_FichaMedica.TelefonoPariente2);
            msqlCommand.Parameters.AddWithValue("?p_celular_pariente_2", p_FichaMedica.CelularPariente2);

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

        public FichaMedicaDTO Load(FichaMedicaDTO p_FichaMedica)
        {
            FichaMedicaDTO retorno = null;
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "SELECT * FROM fichas_medicas WHERE rut = ?p_rut";
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_FichaMedica.Bombero.Rut);

            try
            {
                conexionBD.Open();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    retorno = new FichaMedicaDTO();

                    IBomberoDAO _Bombero = new BomberoDAO();
                    BomberoDTO bombero_rut = new BomberoDTO();

                    bombero_rut.Rut = msqlReader["rut"].ToString();
                    bombero_rut = _Bombero.Load(bombero_rut);

                    retorno.Bombero = bombero_rut;
                    retorno.Hepatitis = bool.Parse(msqlReader["hepatitis"].ToString());
                    retorno.Tifus = bool.Parse(msqlReader["tifus"].ToString());
                    retorno.OtrasEnfermedades = msqlReader["otras_enfermedades"].ToString();
                    retorno.Operaciones = msqlReader["operaciones"].ToString();
                    retorno.HipertensionArterial = bool.Parse(msqlReader["hipertension_arterial"].ToString());
                    retorno.Diabetes = bool.Parse(msqlReader["diabetes"].ToString());
                    retorno.Epilepsia = bool.Parse(msqlReader["epilepsia"].ToString());
                    retorno.Asma = bool.Parse(msqlReader["asma"].ToString());
                    retorno.AntecedentesCronicos = msqlReader["antecedentes_cronicos"].ToString();
                    retorno.MedicamentosToma = msqlReader["medicamentos_toma"].ToString();
                    retorno.MedicamentosNoToma = msqlReader["medicamentos_no_toma"].ToString();
                    retorno.NombrePariente1 = msqlReader["nombre_pariente_1"].ToString();
                    retorno.ParentescoPariente1 = msqlReader["parentesco_pariente_1"].ToString();
                    retorno.TelefonoPariente1 = msqlReader["telefono_pariente_1"].ToString();
                    retorno.CelularPariente1 = msqlReader["celular_pariente_1"].ToString();
                    retorno.NombrePariente2 = msqlReader["nombre_pariente_2"].ToString();
                    retorno.ParentescoPariente2 = msqlReader["parentesco_pariente_2"].ToString();
                    retorno.TelefonoPariente2 = msqlReader["telefono_pariente_2"].ToString();
                    retorno.CelularPariente2 = msqlReader["celular_pariente_2"].ToString();
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

        public bool Update(FichaMedicaDTO p_FichaMedica)
        {
            //MySQL
            MySql.Data.MySqlClient.MySqlConnection conexionBD = ConnectBD();
            string query = "UPDATE fichas_medicas SET rut = ?p_rut, hepatitis = ?p_hepatitis, tifus = ?p_tifus, ";
            query = string.Concat(query, "otras_enfermedades = ?p_otras_enfermedades, operaciones = ?p_operaciones,  ");
            query = string.Concat(query, "hipertension_arterial = ?p_hipertension_arterial, diabetes = ?p_diabetes, epilepsia = ?p_epilepsia, ");
            query = string.Concat(query, "asma = ?p_asma, antecedentes_cronicos = ?p_antecedentes_cronicos, ");
            query = string.Concat(query, "medicamentos_toma = ?p_medicamentos_toma, medicamentos_no_toma = ?p_medicamentos_no_toma, ");
            query = string.Concat(query, "nombre_pariente_1 = ?p_nombre_pariente_1, parentesco_pariente_1 = ?p_parentesco_pariente_1, ");
            query = string.Concat(query, "telefono_pariente_1 = ?p_telefono_pariente_1, celular_pariente_1 = ?p_celular_pariente_1, ");
            query = string.Concat(query, "nombre_pariente_2 = ?p_nombre_pariente_2, parentesco_pariente_2 = ?p_parentesco_pariente_2, ");
            query = string.Concat(query, "telefono_pariente_2 = ?p_telefono_pariente_2, celular_pariente_2 = ?p_celular_pariente_2 ");
            query = string.Concat(query, "WHERE rut = ?p_rut");
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionBD);
            msqlCommand.Parameters.AddWithValue("?p_rut", p_FichaMedica.Bombero.Rut);
            msqlCommand.Parameters.AddWithValue("?p_hepatitis", p_FichaMedica.Hepatitis);
            msqlCommand.Parameters.AddWithValue("?p_tifus", p_FichaMedica.Tifus);
            msqlCommand.Parameters.AddWithValue("?p_otras_enfermedades", p_FichaMedica.OtrasEnfermedades);
            msqlCommand.Parameters.AddWithValue("?p_operaciones", p_FichaMedica.Operaciones);
            msqlCommand.Parameters.AddWithValue("?p_hipertension_arterial", p_FichaMedica.HipertensionArterial);
            msqlCommand.Parameters.AddWithValue("?p_diabetes", p_FichaMedica.Diabetes);
            msqlCommand.Parameters.AddWithValue("?p_epilepsia", p_FichaMedica.Epilepsia);
            msqlCommand.Parameters.AddWithValue("?p_asma", p_FichaMedica.Asma);
            msqlCommand.Parameters.AddWithValue("?p_antecedentes_cronicos", p_FichaMedica.AntecedentesCronicos);
            msqlCommand.Parameters.AddWithValue("?p_medicamentos_toma", p_FichaMedica.MedicamentosToma);
            msqlCommand.Parameters.AddWithValue("?p_medicamentos_no_toma", p_FichaMedica.MedicamentosNoToma);
            msqlCommand.Parameters.AddWithValue("?p_nombre_pariente_1", p_FichaMedica.NombrePariente1);
            msqlCommand.Parameters.AddWithValue("?p_parentesco_pariente_1", p_FichaMedica.ParentescoPariente1);
            msqlCommand.Parameters.AddWithValue("?p_telefono_pariente_1", p_FichaMedica.TelefonoPariente1);
            msqlCommand.Parameters.AddWithValue("?p_celular_pariente_1", p_FichaMedica.CelularPariente1);
            msqlCommand.Parameters.AddWithValue("?p_nombre_pariente_2", p_FichaMedica.NombrePariente2);
            msqlCommand.Parameters.AddWithValue("?p_parentesco_pariente_2", p_FichaMedica.ParentescoPariente2);
            msqlCommand.Parameters.AddWithValue("?p_telefono_pariente_2", p_FichaMedica.TelefonoPariente2);
            msqlCommand.Parameters.AddWithValue("?p_celular_pariente_2", p_FichaMedica.CelularPariente2);


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