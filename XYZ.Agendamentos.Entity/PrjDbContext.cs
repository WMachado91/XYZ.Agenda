using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ.Agendamentos.Entity.DB_Config;
using XYZ.Agendamentos.Entity.Models;

namespace XYZ.Agendamentos.Entity
{
    public class PrjDbContext:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public PrjDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DbConfigAgendamento());

            modelBuilder.Configurations.Add(new DbConfigUsuario());
        }
    }
}
