using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoExemplo.Models
{
    public class Album
    {
        [Key]
        [Required]
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(52, ErrorMessage = "Use menos caracteres")]
        public string Destino { get; set; }

        public string FotoTopo { get; set; }

        [Display(Name = "Data de Início")]
        [Required(ErrorMessage = "Data em formato inválido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataInicio { get; set; }


        [Display(Name = "Data de Início")]
        [Required(ErrorMessage = "Data em formato inválido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataFim { get; set; }

        public ICollection<Imagem> Imagens { get; set; }
    }
}
