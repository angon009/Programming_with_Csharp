using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_02
{
    public class DbContextConfiguration : DbContext
    {
        #region Identifying Database to ERF
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public DbContextConfiguration()
        {
            _connectionString = "Server=ANGON\\SQLEXPRESS; Database = College; User Id = CollegeAdmin; Password = 1234590";
            _assemblyName = typeof(Program).Assembly.FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_assemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }
        #endregion




        //Connecting our classes with ERF
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Stuff> stuffs { get; set; }
    }
}
