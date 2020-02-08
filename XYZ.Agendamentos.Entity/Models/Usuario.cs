using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ.Agendamentos.Entity.Models
{
    class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DtNascimento { get; set; }
        public DateTime DtCriacao { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public virtual List <Agendamento> Agendamentos { get; set; }
    }
}
