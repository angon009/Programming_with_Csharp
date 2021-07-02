using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    public class ClassTakingDbContext : DbContext
    {
        #region Identifying Database to ERF
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public ClassTakingDbContext()
        {
            _connectionString = "Server=ANGON\\SQLEXPRESS; Database = DevSkill; User Id = DevAngon; Password = 1234590";
            _assemblyName = typeof(Program).Assembly.FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if(!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_assemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }
        #endregion




        //Connecting our classes with ERF
        public DbSet<Course> courses { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
    }
}
