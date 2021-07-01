using System;
using System.Data.SqlClient;

namespace DatabasePractice04
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=ANGON\\SQLEXPRESS; Database = Employee; User Id = Office; Password = 1234590";
            using SqlConnection connection = new SqlConnection(connectionString);


            #region Create Operations
            var sql = "insert into BasicInfo (Name , Age , Salary , Years) values ('Joey' , 26 , 30000, 3.5)";
            WriteOperation(sql, connection);

            var sql2 = "insert into BasicInfo(Name, Age, Salary, Years) values('Ross', 29, 60000, 6.2)";
            WriteOperation(sql2, connection);

            var sql3 = "insert into BasicInfo(Name, Age, Salary, Years) values('Chandler', 24, 3000, 0.2)";
            WriteOperation(sql3, connection);

            var sql4 = "insert into BasicInfo(Name, Age, Salary, Years) values ('Ganther' , 32 , 70000 , 10.5)";
            WriteOperation(sql4, connection);
            #endregion

            #region Update Operation
            var sql5 = "update BasicInfo set Name = 'Harry' where Name = 'Ganther'";
            WriteOperation(sql5, connection);

            var sql6 = "update BasicInfo set Age = 44 where Age = 24";
            WriteOperation(sql6, connection);
            #endregion

            #region Delete Operation
            var sql7 = "delete from BasicInfo where Name = 'Chandler' ";
            WriteOperation(sql7, connection);
            #endregion
        }

        public static void WriteOperation(string sql , SqlConnection connection)
        {
            using SqlCommand command = new SqlCommand(sql, connection);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            command.ExecuteNonQuery();
            Console.WriteLine("Operation Successfull");
        }
    }
}
