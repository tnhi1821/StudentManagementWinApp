﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication9.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;
        private string connectionString = "Data Source=DESKTOP-FI68AV1;Initial Catalog=QuanLyHocSinh;Integrated Security=TrueData Source=DESKTOP-FI68AV1;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        private DataProvider() { }

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set => instance = value;
        }

        private SqlCommand GetSqlCommand(SqlConnection connection, string query, object[] parameters)
        {
            SqlCommand command = new SqlCommand(query, connection);
            if (parameters != null)
            {
                int i = 0;
                foreach (string item in query.Split(' '))
                {
                    if (item.Contains('@'))
                        command.Parameters.AddWithValue(item, parameters[i++]);
                }
            }
            return command;
        }

        public void UpdateTable(DataTable dataTable, string table)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM {table}";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    adapter.Update(dataTable);
                    connection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = GetSqlCommand(connection, query, parameters);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    connection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = GetSqlCommand(connection, query, parameters);
                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = GetSqlCommand(connection, query, parameters);
                    data = command.ExecuteScalar();
                    connection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }
    }
}
