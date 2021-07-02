using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Example_03
{
    public class DbContextConfig : DbContext
    {
        #region Identifying Database to ERF
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public DbContextConfig()
        {
            _connectionString = "Server=ANGON\\SQLEXPRESS; Database = Shop; User Id = Shopper; Password = 1234590";
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
        public DbSet<Seller> sellers { get; set; }
        public DbSet<Buyer> buyers { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
