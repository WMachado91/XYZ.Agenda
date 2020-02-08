using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ.Agendamentos.Entity.Models;

namespace XYZ.Agendamentos.Entity.DB_Config
{
     class DbConfigAgendamento : BaseDbConfig<Agendamento>
    {
        protected override void ConfigColunas()
        { 
            Property(p => p.Id).HasColumnName("Id_Agendamento")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            
            Property(p => p.DtAgendamento)
                .HasColumnName("Dt_Agendamento")
                  .IsOptional();
            Property(p => p.CEP)
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnName("CEP");
            Property(p => p.Cidade)
                .IsOptional()
                .HasMaxLength(100)
                .HasColumnName("Cidade");
            Property(p => p.Estado)
                .IsOptional()
                .HasMaxLength(100)
                .HasColumnName("Estado");
            Property(p => p.Endereco)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("Endereco");
            Property(p => p.Descricao)
                .IsOptional()
                 .HasMaxLength(255)
                   .HasColumnName("Descricao");

            Property(p => p.Titulo)
                .IsRequired()
                .HasColumnName("Titulo")
                .HasMaxLength(255);

            Property(p => p.DtCriacao).IsOptional();
        }

        protected override void ConfigFK()
        {
        }

        protected override void ConfigPK()
        {
            HasKey(pk => pk.Id);
            
        }

        protected override void ConfigTabela()
        {
            ToTable("TB_Agendamentos");
            
        }
    }
}
