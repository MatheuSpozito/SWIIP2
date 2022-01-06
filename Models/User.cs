using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWIIP2.Models
{    
    public class User
    {
        [Key]
        [DisplayName("Código do Usuário")]        
        public int Id { get; set; }

        [DisplayName("Usuário")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Username { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [PasswordPropertyText]
        public string Password { get; set; }

        public Boolean Status { get; set; }

        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Role { get; set; }

    }
}
