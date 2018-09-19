using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do usuário é requirido")]
        public string Nome { get; set; }
        [DisplayName("Data Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "A data de nascimento do usuário é requirida")]
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
