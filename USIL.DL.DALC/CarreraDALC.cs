using USIL.BL.BE;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using System.Data;

namespace USIL.DL.DALC
{
    public class CarreraDALC
    {
        public List<CarreraBE> CarreraListar()
        {
            String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
            SqlConnection Con = new SqlConnection(strCadenaConexion);
            String strSP = "uspCarreraListar";
            SqlCommand Cmd = new SqlCommand(strSP, Con);

            List<CarreraBE> LstCarreraBe = new List<CarreraBE>();

            Con.Open();
            SqlDataReader reader = Cmd.ExecuteReader();
            while (reader.Read()) 
            {
                CarreraBE objCarreraBE = new CarreraBE();
                objCarreraBE.CarreraId = Convert.ToInt32(reader[0]);
                objCarreraBE.CodigoCarrera = reader[1].ToString();
                objCarreraBE.NombreCarrera = reader[2].ToString();
                objCarreraBE.EstadoCarrera = reader[3].ToString();

            }
            reader.Close();

            return LstCarreraBe;
        }

        public bool CarreraInsertar(CarreraBE objCarreraBE)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspCarreraAgregar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[3];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoCarrera";
                arrSqlParameter[0].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[0].Size = 50;
                arrSqlParameter[0].Value = objCarreraBE.CodigoCarrera;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = "@NombreCarrera";
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 100;
                arrSqlParameter[1].Value = objCarreraBE.NombreCarrera;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = "@EstadoCarrera";
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objCarreraBE.EstadoCarrera;


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
        public bool CarreraEditar(CarreraBE objCarreraBE)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspCarreraEditar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[3];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoCarrera";
                arrSqlParameter[0].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[0].Size = 50;
                arrSqlParameter[0].Value = objCarreraBE.CodigoCarrera;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = "@NombreCarrera";
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 100;
                arrSqlParameter[1].Value = objCarreraBE.NombreCarrera;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = "@EstadoCarrera";
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objCarreraBE.EstadoCarrera;

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
        public bool CarreraEliminar(String Codigo)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspCarreraEliminar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[1];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoCarrera";
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

        public bool CarreraObtener(String Codigo)
        {
            try
            {
                String strCadenaConexion = "server=DESKTOP-C1RRVGM;dtabase=USILDB;Integrated Security=true;";
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspCarreraObtener";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[1];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@CodigoCarrera";
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