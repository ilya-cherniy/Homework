using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DBAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //Console.WriteLine(connection.State); 
            //Console.WriteLine(connection.ClientConnectionId);
            //connection.Close();
            //var query = "SELECT * FROM [User]";
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(query, connection);
            //    var reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        var id = reader.GetInt32(0);
            //        var name = reader.GetString(1);
            //        var phone = reader.GetString(2);
            //        var role = reader.GetInt32(3);
            //        Console.WriteLine($"{id}, {name}, {phone}, {role}");
            //    }
            //}
            //var query = "sp_AddPhoneNumber";
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    SqlCommand cmd = new SqlCommand(query, connection);

            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    SqlParameter paramOne = new SqlParameter
            //    {
            //        ParameterName = "@number",
            //        Value = "42345"
            //    };
            //    SqlParameter paramTwo = new SqlParameter
            //    {
            //        ParameterName = "@id",
            //        Value = "7"
            //    };
            //    cmd.Parameters.Add(paramOne);
            //    cmd.Parameters.Add(paramTwo);

            //    cmd.ExecuteScalar();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Transaction = transaction;

                try
                {
                    cmd.CommandText = "SELECT * FROM [User]";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO [User] (Name, Phone) VALUES ('Igor', '555')";
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "SELECT * FROM [Students]";
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
            }
    }
    }
}
