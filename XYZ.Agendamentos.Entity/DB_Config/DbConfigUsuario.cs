using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ.Agendamentos.Entity.Models;

namespace XYZ.Agendamentos.Entity.DB_Config
{
    class DbConfigUsuario : BaseDbConfig<Usuario>
    {
        protected override void ConfigColunas()
        {
            Property(p => p.Id).HasColumnName("Id_Usuario")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

        }

        protected override void ConfigFK()
        {
            HasMany(fk => fk.Agendamentos)
                .WithRequired( fk => fk.Usuario)
                .HasForeignKey( fk => fk.IdUsuario)
                .WillCascadeOnDelete(false);
        }

        protected override void ConfigPK()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigTabela()
        {
            ToTable("Tb_Usuarios");
        }
    }
}
