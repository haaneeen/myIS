using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace myIS.Data_Access
{
    class AdoHelper
    {

        //get the connection string from the app.config file
        static string connectionString = Properties.Settings.Default.Properties.ToString();

        //declare the db connection
        static OleDbConnection con = new OleDbConnection(connectionString);

        /// <summary>
        /// To Execute queries which returns result set (table / relation)
        /// </summary>
        /// <param name="query">the query string</param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string query)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);
                System.Data.OleDb.OleDbDataAdapter tableAdapter = new System.Data.OleDb.OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                tableAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// To Execute update / insert / delete queries
        /// </summary>
        /// <param name="query">the query string</param>
        public static void ExecuteNonQuery(string query)
        {
            if (query == "") return;
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool isEmpty(DataTable dt)
        {
            int rows = dt.Rows.Count;
            if (rows == 0)
            {
                return true;
            }
            return false;
        }
    }
}

