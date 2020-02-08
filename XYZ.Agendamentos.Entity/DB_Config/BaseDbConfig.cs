using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ.Agendamentos.Entity.DB_Config
{
    public abstract class BaseDbConfig<T> : EntityTypeConfiguration<T> where T : class
    {

        public BaseDbConfig()
        {
            ConfigPK();

            ConfigColunas();

            ConfigTabela();

            ConfigFK();

        }

        protected abstract void ConfigColunas();


        protected abstract void ConfigFK();


        protected abstract void ConfigPK();


        protected abstract void ConfigTabela();
        
    }
}
