using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost;DataBase=DB-HD;User ID=administrator;Password=hola1234;TrustServerCertificate=True;");
        }

        public DbSet<Profile> Profile { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Task> Task { get; set; }

    }
}
