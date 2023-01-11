using Microsoft.EntityFrameworkCore;
using ModeleDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeleDB
{
    public class ModelContext : DbContext
    {

        public DbSet<ModeleModel> Models { get; set; }

        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ModeleDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            optionsBuilder.UseSqlServer(cs);
        }
    }
}
