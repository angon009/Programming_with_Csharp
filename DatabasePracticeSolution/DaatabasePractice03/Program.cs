using System;
using System.Data.SqlClient;

namespace DaatabasePractice03
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=ANGON\\SQLEXPRESS; Database = Employee; User Id = Office; Password = 1234590";
            using SqlConnection connection = new SqlConnection(connectionString);


            //Inserting data in tables
            var sql = "insert into BasicInfo (Name , Age , Salary , Years) values ('Jack', 34, 150000, 7.5)";
            using SqlCommand command = new SqlCommand(sql, connection);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            command.ExecuteNonQuery();
            Console.WriteLine("First insertion done");

             
 

         }
    }
}
