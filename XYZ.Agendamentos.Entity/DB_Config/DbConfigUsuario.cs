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
            Property(p => p.Id)
                .HasColumnName("Id_Usuario")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Nome)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Nome_Usuario");

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Email");

            Property(p => p.CPF)
                .HasColumnName("CPF")
                .IsRequired()
                .HasMaxLength(14);

            Property(p => p.Senha)
                .IsRequired()
                .HasColumnName("Senha");
            Property(p => p.Telefone)
                .IsOptional()
                .HasMaxLength(20)
                .HasColumnName("Contato");

            Property(p => p.DtCriacao)
                .IsOptional()
                .HasColumnName("Dt_Criacao");

            Property(p => p.DtNascimento)
                .IsOptional()
                .HasColumnName("Dt_Nascimento"); ;

        }

        protected override void ConfigFK()
        {
            HasMany(fk => fk.Agendamentos)
                .WithRequired(fk => fk.Usuario)
                .HasForeignKey(fk => fk.IdUsuario)
                .WillCascadeOnDelete(false);

            HasIndex(i => i.CPF).IsUnique(true);
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
