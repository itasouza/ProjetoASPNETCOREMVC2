using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoExemplo.Models
{
    public class Imagem
    {
        [Key]
        [Required]
        public int ImagemId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Link { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
