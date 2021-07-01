using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabasePractice07
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server = ANGON\\SQLEXPRESS; Database = test2; User Id = School; Password=1234590";
            SqlConnection connection = new SqlConnection(connectionString);

            var sql = "select * from Stuffs";
            var stuffs = ReadOperation(sql,connection);

            foreach(var stuff in stuffs)
            {
                Console.WriteLine($"{stuff.id}   {stuff.name}   {stuff.salary}  {stuff.years}");
            }

        }

        public static List<Stuff> ReadOperation(string sql, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(sql, connection);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            var reader = command.ExecuteReader();

            var stuff = new List<Stuff>();

            while(reader.Read())
            {
                var stuffInfo = new Stuff();

                stuffInfo.id = (int)reader["Id"];
                stuffInfo.name = (string)reader["Designation"];
                stuffInfo.salary = (int)reader["Salary"];
                stuffInfo.years = (int)reader["Years"];

                stuff.Add(stuffInfo);
            }
            return stuff;
        }
    }

}
