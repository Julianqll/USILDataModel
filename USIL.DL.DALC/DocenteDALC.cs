using USIL.BL.BE;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using System.Data;

namespace USIL.DL.DALC
{
    public class DocenteDALC
    {
        public List<DocenteBE> DocenteListar()
        {
            String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
            SqlConnection Con = new SqlConnection(strCadenaConexion);
            String strSP = "uspDocenteListar";
            SqlCommand Cmd = new SqlCommand(strSP, Con);

            List<DocenteBE> LstDocenteBe = new List<DocenteBE>();

            Con.Open();
            SqlDataReader reader = Cmd.ExecuteReader();
            while (reader.Read()) 
            {
                DocenteBE objDocenteBE = new DocenteBE();
                objDocenteBE.DocenteId = Convert.ToInt32(reader[0]);
                objDocenteBE.CodigoDocente = reader[1].ToString();
                objDocenteBE.Nombres = reader[2].ToString();
                objDocenteBE.ApellidoPaterno = reader[3].ToString();
                objDocenteBE.ApellidoMaterno = reader[4].ToString();
                objDocenteBE.NroDocumento = reader[5].ToString();
                objDocenteBE.DocumentoId = Convert.ToInt32(reader[6]);
                objDocenteBE.CarreraId = Convert.ToInt32(reader[7]);
                objDocenteBE.Estado = reader[8].ToString();
                LstDocenteBe.Add(objDocenteBE);

            }
            reader.Close();

            return LstDocenteBe;
        }

        public bool DocenteInsertar(DocenteBE objDocenteBE)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspDocenteAgregar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[8];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoDocente";
                arrSqlParameter[0].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[0].Size = 50;
                arrSqlParameter[0].Value = objDocenteBE.CodigoDocente;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = "@Nombres";
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 50;
                arrSqlParameter[1].Value = objDocenteBE.Nombres;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = "@ApellidoPaterno";
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 50;
                arrSqlParameter[2].Value = objDocenteBE.ApellidoPaterno;

                arrSqlParameter[3] = new SqlParameter();
                arrSqlParameter[3].ParameterName = "@ApellidoMaterno";
                arrSqlParameter[3].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[3].Size = 50;
                arrSqlParameter[3].Value = objDocenteBE.ApellidoMaterno;

                arrSqlParameter[4] = new SqlParameter();
                arrSqlParameter[4].ParameterName = "@NroDocumento";
                arrSqlParameter[4].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[4].Size = 15;
                arrSqlParameter[4].Value = objDocenteBE.NroDocumento;

                arrSqlParameter[5] = new SqlParameter();
                arrSqlParameter[5].ParameterName = "@DocumentoId";
                arrSqlParameter[5].SqlDbType = SqlDbType.Int;
                arrSqlParameter[5].Value = objDocenteBE.DocumentoId;

                arrSqlParameter[6] = new SqlParameter();
                arrSqlParameter[6].ParameterName = "@CarreraId";
                arrSqlParameter[6].SqlDbType = SqlDbType.Int;
                arrSqlParameter[6].Value = objDocenteBE.CarreraId;

                arrSqlParameter[7] = new SqlParameter();
                arrSqlParameter[7].ParameterName = "@Estado";
                arrSqlParameter[7].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[7].Size = 3;
                arrSqlParameter[7].Value = objDocenteBE.Estado;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DocenteEditar(DocenteBE objDocenteBE)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspDocenteEditar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[8];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoDocente";
                arrSqlParameter[0].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[0].Size = 50;
                arrSqlParameter[0].Value = objDocenteBE.CodigoDocente;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = "@Nombres";
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 50;
                arrSqlParameter[1].Value = objDocenteBE.Nombres;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = "@ApellidoPaterno";
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 50;
                arrSqlParameter[2].Value = objDocenteBE.ApellidoPaterno;

                arrSqlParameter[3] = new SqlParameter();
                arrSqlParameter[3].ParameterName = "@ApellidoMaterno";
                arrSqlParameter[3].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[3].Size = 50;
                arrSqlParameter[3].Value = objDocenteBE.ApellidoMaterno;

                arrSqlParameter[4] = new SqlParameter();
                arrSqlParameter[4].ParameterName = "@NroDocumento";
                arrSqlParameter[4].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[4].Size = 15;
                arrSqlParameter[4].Value = objDocenteBE.NroDocumento;

                arrSqlParameter[5] = new SqlParameter();
                arrSqlParameter[5].ParameterName = "@DocumentoId";
                arrSqlParameter[5].SqlDbType = SqlDbType.Int;
                arrSqlParameter[5].Value = objDocenteBE.DocumentoId;

                arrSqlParameter[6] = new SqlParameter();
                arrSqlParameter[6].ParameterName = "@CarreraId";
                arrSqlParameter[6].SqlDbType = SqlDbType.Int;
                arrSqlParameter[6].Value = objDocenteBE.CarreraId;

                arrSqlParameter[7] = new SqlParameter();
                arrSqlParameter[7].ParameterName = "@Estado";
                arrSqlParameter[7].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[7].Size = 3;
                arrSqlParameter[7].Value = objDocenteBE.Estado;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DocenteEliminar(String Codigo)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspDocenteEliminar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[1];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@Codigo";
                arrSqlParameter[0].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[0].Size = 50;
                arrSqlParameter[0].Value = Codigo;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DocenteObtener(String Codigo)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspDocenteObtener";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[1];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@Codigo";
                arrSqlParameter[0].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[0].Size = 50;
                arrSqlParameter[0].Value = Codigo;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}