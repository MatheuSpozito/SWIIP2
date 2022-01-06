using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWIIP2.Models
{
    public class Product
    {   
        [Key]
        [DisplayName("Código do Produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Id { get; set; }

        [DisplayName("Nome do Produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public float Price { get; set; }

        [DisplayName("Ativo")]
        public Boolean Status { get; set; }

        [DisplayName("Cadastrado por: ")]
        public string UserRegister { get; set; }

        [DisplayName("Atualizado por: ")]
        public string UserUpdate { get; set; }



    }
}
