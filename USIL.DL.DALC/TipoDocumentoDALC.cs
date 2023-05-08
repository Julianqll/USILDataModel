using USIL.BL.BE;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using System.Data;

namespace USIL.DL.DALC
{
    public class TipoDocumentoDALC
    {
        public List<TipoDocumentoBE> TipoDocumentoListar()
        {
            String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
            SqlConnection Con = new SqlConnection(strCadenaConexion);
            String strSP = "uspTipoDocumentoListar";
            SqlCommand Cmd = new SqlCommand(strSP, Con);

            List<TipoDocumentoBE> LstTipoDocumentoBe = new List<TipoDocumentoBE>();

            Con.Open();
            SqlDataReader reader = Cmd.ExecuteReader();
            while (reader.Read()) 
            {
                TipoDocumentoBE objTipoDocumentoBE = new TipoDocumentoBE();
                objTipoDocumentoBE.TipoDocumentoId = Convert.ToInt32(reader[0]);
                objTipoDocumentoBE.CodigoTipoDocumento = reader[1].ToString();
                objTipoDocumentoBE.NombreTipoDocumento = reader[2].ToString();
                objTipoDocumentoBE.EstadoTipoDocumento = reader[3].ToString();

            }
            reader.Close();

            return LstTipoDocumentoBe;
        }

        public bool TipoDocumentoInsertar(TipoDocumentoBE objTipoDocumentoBE)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoDocumentoAgregar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[3];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoTipoDocumento";
                arrSqlParameter[0].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[0].Size = 50;
                arrSqlParameter[0].Value = objTipoDocumentoBE.CodigoTipoDocumento;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = "@NombreTipoDocumento";
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 100;
                arrSqlParameter[1].Value = objTipoDocumentoBE.NombreTipoDocumento;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = "@EstadoTipoDocumento";
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objTipoDocumentoBE.EstadoTipoDocumento;


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
        public bool TipoDocumentoEditar(TipoDocumentoBE objTipoDocumentoBE)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoDocumentoEditar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[3];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoTipoDocumento";
                arrSqlParameter[0].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[0].Size = 50;
                arrSqlParameter[0].Value = objTipoDocumentoBE.CodigoTipoDocumento;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = "@NombreTipoDocumento";
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 100;
                arrSqlParameter[1].Value = objTipoDocumentoBE.NombreTipoDocumento;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = "@EstadoTipoDocumento";
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objTipoDocumentoBE.EstadoTipoDocumento;

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
        public bool TipoDocumentoEliminar(String Codigo)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoDocumentoEliminar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[1];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoTipoDocumento";
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

        public bool TipoDocumentoObtener(String Codigo)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoDocumentoObtener";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[1];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoTipoDocumento";
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