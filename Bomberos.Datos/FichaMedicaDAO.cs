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
            query = string.Concat(query, "medicamentos_toma, medicamentos_no_toma) VALUES (?p_rut,?p_hepatitis,?p_tifus, ");
            query = string.Concat(query, "?p_otras_enfermedades,?p_operaciones,?p_hipertension_arterial,?p_diabetes, ");
            query = string.Concat(query, "?p_epilepsia,?p_asma,?p_antecedentes_cronicos,?p_medicamentos_toma, ?p_medicamentos_no_toma)");
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
            query = string.Concat(query, "medicamentos_toma = ?p_medicamentos_toma, medicamentos_no_toma = ?p_medicamentos_no_toma ");
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