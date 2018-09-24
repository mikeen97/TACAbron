using System;
using System.Data.SqlClient;

namespace GUI_V_2{


    public class coneccion
    {
         public SqlConnection connect;

        public coneccion(){
           
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
                Console.WriteLine(e.ToString());
            }

        }

        public void connectar()
        {
            connect.Open();
            Console.WriteLine("Exito");
            String query = "INSERT INTO MODELOS VALUES (1030,98,600.45);";
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();
          
        }

     
    }
}
