using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace MyFormsApp.Classes
{
    public static class DataBankZugriff 

    {

            //public static DataTable dtCbxBankKontos;
            //public static DataRow drCbxBankKontos;
        public static DataTable ExecuteDataTable(string storedProcedureName, params SqlParameter[] arrParameter)
            {

            DataTable dt = new DataTable();

            using (SqlConnection cnn = new SqlConnection(@"Data Source=TEW-NB92\SQLEXPRESS; Initial Catalog=BankApp;Integrated Security=false;user id=sa;password=testo123$"))


            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedureName;
                    if (arrParameter != null)
                    {
                        foreach (SqlParameter param in arrParameter)
                            cmd.Parameters.Add(param);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static void WriteDataBase(string storedProcedureName, params SqlParameter[] arrParameter)
        {

            //ACHTUNG Datasource wird lokal und deswegen muss jeder für sich eigenen Datasource (server name) eintragen


            using (SqlConnection cnn = new SqlConnection(@"Data Source=TEW-NB92\SQLEXPRESS; Initial Catalog=BankApp;Integrated Security=false;user id=sa;password=testo123$"))




            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedureName;

                    if (arrParameter != null)
                    {
                        foreach (SqlParameter param in arrParameter)
                            cmd.Parameters.Add(param);
                    }

                    int anzRecord = cmd.ExecuteNonQuery();
                    if (anzRecord > 0)
                    {
                        Console.WriteLine("Datensatz erfolgreich gespeichert");
                    }
                    else
                    {
                        Console.WriteLine("Datensatz konnte nicht gespeichert werden");
                    }

                }
            }
        }
    }
}