﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI_V_2
{


    public class conexion
    {
        public SqlConnection connect;
        public conexion(String username, String password)
        {

            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "Aeropuerto.database.windows.net";
                cb.UserID = username;
                cb.Password = password;
                cb.InitialCatalog = "Aeropuerto";
                connect = new SqlConnection(cb.ConnectionString);

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public conexion()
        {

            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "Aeropuerto.database.windows.net";
                cb.UserID = "Administrador";
                cb.Password = "Holamundo007";
                cb.InitialCatalog = "Aeropuerto";
                connect = new SqlConnection(cb.ConnectionString);

            }
            catch (SqlException e)

            {

                MessageBox.Show("Error al ejecutar Query", "Se mamut", MessageBoxButtons.OK);
            }

        }

        public void connectar()
        {
            connect.Open();
            /* String query = "EXECUTE ";
             SqlCommand command = new SqlCommand(query, connect);
             SqlDataReader reader = command.ExecuteReader();*/

        }
        public void desconectar()
        {
            connect.Close();
        }
        public void ExecuteQuery(String query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error al ejecutar Query", "Se mamut", MessageBoxButtons.OK);
            }
        }


    }
}