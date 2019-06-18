using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ValidacaoPersonalizada.Validacao;

namespace ValidacaoDados.Models
{
    public class Pessoa
    {

        public int PessoaId { get; set; }
        [Required(ErrorMessage ="Campo obrigatório")]
        [StringLength(20,ErrorMessage ="Use menos caracteres")]

        [Remote("UsuarioExisteAsync","Pessoas")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [Range(1,90,ErrorMessage ="Você não é velho assim! Digite um valor válido")]
        [Adulto] //validação personalizada
        public int Idade { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email inválido")]
        [StringLength(50,ErrorMessage = "Use menos caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email inválido")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        [Compare("Email",ErrorMessage ="O email informado e diferente")]
        public string ConfirmarEmail  { get; set; }
    }
}
