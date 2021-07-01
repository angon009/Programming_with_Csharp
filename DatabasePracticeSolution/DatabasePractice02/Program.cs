using System;
using System.Data.SqlClient;

namespace DatabasePractice02
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionCredential = "Server=ANGON\\SQLEXPRESS;Database=test2;User Id=School;Password=1234590;";
            using SqlConnection connection = new SqlConnection(connectionCredential);

            var sql = "insert into students (Name , cgpa) values ('Shahran' , 3.5)";
            using SqlCommand command = new SqlCommand(sql , connection);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            command.ExecuteNonQuery();
            Console.WriteLine("Insertion Successful");




            var sql2 = "insert into students(Name , cgpa) values('Sonjoy' , 4.00)";
            using SqlCommand command2 = new SqlCommand(sql2 , connection);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            command2.ExecuteNonQuery();
            Console.WriteLine("Insertion Successful");
        }
    }
}
