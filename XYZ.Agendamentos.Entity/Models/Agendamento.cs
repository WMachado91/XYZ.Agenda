using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ.Agendamentos.Entity.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public DateTime DtAgendamento { get; set; }
        public DateTime DtCriacao { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public Usuario Usuario { get; set; }




    }
}
