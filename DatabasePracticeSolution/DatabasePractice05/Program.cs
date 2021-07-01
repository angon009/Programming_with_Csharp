using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabasePractice05
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server = ANGON\\SQLEXPRESS; Database = test2; User Id = School; Password=1234590";
            using SqlConnection connection = new SqlConnection(connectionString);

            var sql = "select * from Students";
            var students = ReadOperation(sql, connection);

            foreach(var student in students)
            {
                Console.WriteLine($"ID : {student.Id} Name : {student.Name}  CGPA : {student.Cgpa}");
            }
        }

        public static List<Student> ReadOperation(string sql , SqlConnection connection)
        {
            using SqlCommand command = new SqlCommand(sql , connection);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            var reader = command.ExecuteReader();

            var students = new List<Student>();

            while(reader.Read())
            {
                var student = new Student();
                student.Name = (string)reader["Name"];
                student.Cgpa = (double)(decimal)reader["cgpa"];
                student.Id = (int)reader["Id"];

                students.Add(student);
            }

            return students;
        }

         
    }
}
