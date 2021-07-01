using System;
using System.Data.SqlClient;

namespace DatabasePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=ANGON\\SQLEXPRESS; Database=PracticeDatabase; User Id=Angon; Password=1234590;";
            using SqlConnection connection = new SqlConnection(connectionString);


            var sql = "insert into students (Name , Age , Weight) values ('Brad' , 26 , 46.78)";
            using SqlCommand command = new SqlCommand(sql , connection);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();


            command.ExecuteNonQuery();

            Console.WriteLine("Insert Done");

        }
    }
}
