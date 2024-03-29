﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using ParkingMangement.Utils;

namespace ParkingMangement
{
    class Database
    {
        //protected static String _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParkingManagement.accdb";
        protected static String _connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ParkingManagement.mdb";

        static OleDbConnection connection;
        public static void OpenConnection()
        {
            try
            {
                connection = new OleDbConnection(_connectionString);
                connection.Open();
            }
            catch
            {

            }
        }

        public static void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        public static DataTable ExcuQuery(string sql)
        {
            try
            {
                OpenConnection();
                DataTable dt = new DataTable();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = sql;
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                CloseConnection();
                return dt;
            } catch (Exception e)
            {
                //MessageBox.Show(Constant.sMessageCommonError);
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static bool ExcuNonQuery(string sql)
        {
            try
            {
                OpenConnection();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = sql;
                int result = command.ExecuteNonQuery();
                CloseConnection();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (OleDbException Ex)
            {
                if (Ex.ErrorCode == -2147467259)
                {
                    //This code happens ONLY when trying to add duplicated values to the primary key in the database, 
                    // in this case just do nothing and continue loading the other no duplicated values
                    MessageBox.Show(Constant.sMessageDuplicateDataError);
                } else
                {
                    MessageBox.Show(Constant.sMessageCommonError);
                }
                return false;
            }
        }
    }
}
