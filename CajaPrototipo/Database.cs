using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaPrototipo
{
    class Database
    {
        static String con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alan\Desktop\CajaPrototipo\CajaPrototipo\Database.mdf;Integrated Security=True;Connect Timeout=30";

        public static int Login(string usuario, string password)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("ppUsuarios", openCon))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@password", password);

                    openCon.Open();

                    return Convert.ToInt32(command.ExecuteScalar());

                }
            }
        }

        public static DataSet ObtenerCliente(string cedula)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("Select * from tblCostumers where Idcard=@cedula", openCon))
                {
                    Program.log.Info("Databse Query Execution : " + command.CommandText + " - Parameters : " + cedula);

                    command.Parameters.AddWithValue("@cedula", cedula);

                    openCon.Open();

                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        using (DataSet ds = new DataSet())
                        {

                            sda.Fill(ds);


                            return ds;
                        }
                    }
                }
            }
        }

        public static DataTable ObtenerCliente2(string cedula)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("Select * from tblCostumers where Idcard=@cedula", openCon))
                {
                    Program.log.Info("Databse Query Execution : " + command.CommandText + " - Parameters : " + cedula);

                    command.Parameters.AddWithValue("@cedula", cedula);

                    openCon.Open();

                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        using (DataTable ds = new DataTable())
                        {

                            sda.Fill(ds);


                            return ds;
                        }
                    }
                }
            }
        }
        public static System.Decimal ObtenerMonto(string numero_de_cuenta)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("SELECT  *  from tblCostumers WHERE AccountNum = '" + numero_de_cuenta + "'", openCon))
                {

                    Program.log.Info("Databse Query Execution : " + command.CommandText);


                    openCon.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        System.Decimal monto = (decimal)reader.GetSqlMoney(reader.GetOrdinal("Mount"));

                        return monto;

                    }
                }
            }
            return 0;
        }

        internal static bool IsOpenCloseTransExists(string query)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, openCon))
                {
                    openCon.Open();

                    Program.log.Info("Databse Query Execution : " + query);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int count = reader.GetInt32(reader.GetOrdinal("count"));

                        return count == 1;

                    }
                }
            }

            return false;
        }

        internal static void UpdateOpenCloseTrans(string query)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                using (SqlCommand command = new SqlCommand(query, openCon))
                {

                    Program.log.Info("Databse Query Execution : " + query);

                    openCon.Open();

                    adapter.InsertCommand = new SqlCommand(query, openCon);
                    adapter.InsertCommand.ExecuteNonQuery();

                    openCon.Close();
                }
            }
        }

        internal static decimal ObtenerDiaMonto(string usuario)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("SELECT  *  from tbl_TransaccionDiaria WHERE Usuario = '" + usuario + "' and date = '" + DateTime.Now.ToString("M/d/yyyy") + "'", openCon))
                {
                    Program.log.Info("Databse Query Execution : " + command.CommandText);

                    openCon.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        System.Decimal monto = (decimal)reader.GetSqlMoney(reader.GetOrdinal("cerrar"));

                        return monto;

                    }
                }
            }
            return 0;

        }

        /*
        public static int Verificacion(string usuario, string cedula)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("ppVerificar", openCon))
                {

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@usuario", usuario);

                    openCon.Open();

                    return Convert.ToInt32(command.ExecuteScalar());

                }
            }
        }
        */
        internal static void InsertOpenCloseTrans(string query)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, openCon))
                {

                    Program.log.Info("Databse Query Execution : " + query);

                    openCon.Open();

                    command.ExecuteNonQuery();

                    openCon.Close();

                }
            }
        }

        internal static string getEmail(string numero_de_cuenta)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("Select * from tblCostumers where AccountNum=@numero_de_cuenta", openCon))
                {
                    command.Parameters.AddWithValue("@numero_de_cuenta", numero_de_cuenta);

                    openCon.Open();

                    Program.log.Info("Databse Query Execution : " + command.CommandText + " - Parameters : " + numero_de_cuenta);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string email = reader.GetString(reader.GetOrdinal("Email"));

                        return email;

                    }
                }
            }
            return null;
        }

        internal static void deleteDayTrans(string numero_de_cuenta, decimal monto)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("delete from tbl_loan where numero_de_cuenta=@numero_de_cuenta and monto=@monto", openCon))
                {
                    command.Parameters.AddWithValue("@numero_de_cuenta", numero_de_cuenta);
                    command.Parameters.AddWithValue("@monto", monto);

                    openCon.Open();

                    Program.log.Info("Databse Query Execution : " + command.CommandText + " - Parameters : " + numero_de_cuenta+", "+monto);

                    command.ExecuteNonQuery();

                    openCon.Close();
                }
            }
        }

        internal static decimal[] getLoan(string numero_de_cuenta)
        {
            decimal[] loans = new decimal[
                getCount("Select count(*) count from tbl_loan where numero_de_cuenta='" + numero_de_cuenta + "'")
                ];

            Program.log.Info("Databse Query Execution : Select count(*) count from tbl_loan where numero_de_cuenta = '" + numero_de_cuenta + "'");

            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("select monto from tbl_loan where numero_de_cuenta=@numero_de_cuenta", openCon))
                {
                    command.Parameters.AddWithValue("@numero_de_cuenta", numero_de_cuenta);

                    openCon.Open();

                    Program.log.Info("Databse Query Execution : " + command.CommandText + " - Parameters : " + numero_de_cuenta);

                    SqlDataReader reader = command.ExecuteReader();

                    int i = 0;
                    
                    while (reader.Read())
                    {
                        loans[i] = (decimal)reader.GetSqlMoney(reader.GetOrdinal("Monto"));

                        
                        i++;

                    }
                }
            }
            return loans;
        }

        private static int getCount(string query)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, openCon))
                {
                
                    openCon.Open();

                    Program.log.Info("Databse Query Execution : " + query);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        return reader.GetInt32(reader.GetOrdinal("count"));
                    }
                }
            }
            return 0;
        }

        public static void AgregarTransaccion(string numero_de_cuenta, string transaccion, decimal monto, string date)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("insert into tblTransactions(AccountNum,TransactType,TransactMount,TransactDate) values (@numero_de_cuenta,@transaccion ,@monto ,@date)", openCon))
                {
                    command.Parameters.AddWithValue("@numero_de_cuenta", numero_de_cuenta);
                    command.Parameters.AddWithValue("@transaccion", transaccion);
                    command.Parameters.AddWithValue("@monto", monto);
                    command.Parameters.AddWithValue("@date", date);

                    Program.log.Info("Databse Query Execution : " + command.CommandText + " - Parameters : " + numero_de_cuenta + ", " + transaccion + ", " + monto + ", " + date);

                    openCon.Open();

                    command.ExecuteNonQuery();

                    openCon.Close();

                }
            }
        }

        public static void ActualizarMonto(string numero_de_cuenta, decimal monto)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                string query = "UPDATE tblCostumers SET Mount =" + monto + " Where AccountNum ='" + numero_de_cuenta + "'";

                SqlDataAdapter adapter = new SqlDataAdapter();
                
                using (SqlCommand command = new SqlCommand(query, openCon))
                {

                    Program.log.Info("Databse Query Execution : " + command.CommandText + " - Parameters : " + numero_de_cuenta + ", " + monto);

                    openCon.Open();

                    adapter.InsertCommand = new SqlCommand(query, openCon);
                    adapter.InsertCommand.ExecuteNonQuery();
                    
                    openCon.Close();
                }
            }
        }



        public static string ObtenerNombreDeUsuario(string usuario)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("Select * from tblUsers where Username=@usuario", openCon))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);

                    openCon.Open();

                    Program.log.Info("Databse Query Execution : " + command.CommandText + " - Parameters : " + usuario);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string apellido = reader.GetString(reader.GetOrdinal("Apellido"));
                        string nombre = reader.GetString(reader.GetOrdinal("Nombre"));

                        return nombre + " " + apellido;

                    }
                }
            }
            return null;
        }

        public static string ObtenerTransacciones(string numero_de_cuenta)
        {
            using (SqlConnection openCon = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand("Select * from tblCostumers where AccountNum=@numero_de_cuenta", openCon))
                {
                    command.Parameters.AddWithValue("@numero_de_cuenta", numero_de_cuenta);

                    openCon.Open();

                    Program.log.Info("Databse Query Execution : " + command.CommandText + " - Parameters : " + numero_de_cuenta);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string apellido = reader.GetString(reader.GetOrdinal("Apellido"));
                        string nombre = reader.GetString(reader.GetOrdinal("Nombre"));

                        return nombre + " " + apellido;

                    }
                }
            }
            return null;
        }
    }
}
