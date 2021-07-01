using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabasePractice06
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server = ANGON\\SQLEXPRESS; Database = test2; User Id = School; Password=1234590";
            using SqlConnection connection = new SqlConnection(connectionString);

            var sql = "select * from Teacher";

            var teachers = ReadOperation(sql, connection); 
            foreach(var teacher in teachers)
            {
                Console.WriteLine($"{teacher.id}   {teacher.name}   {teacher.years}  {teacher.rating}");
            }
        }

        public static List<Teacher> ReadOperation(string sql , SqlConnection connection)
        {
            using SqlCommand command = new SqlCommand(sql, connection);
             

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            var reader = command.ExecuteReader();


            var teachers = new List<Teacher>();
            while(reader.Read())
            {
                var teacher = new Teacher();

                teacher.id = (int)reader["Id"];
                teacher.name = (string)reader["Name"];
                teacher.years = (int)reader["Years"];
                teacher.rating = (double)(decimal)reader["Rating"];

                teachers.Add(teacher);
            }

            return teachers;
        }
    }
}
