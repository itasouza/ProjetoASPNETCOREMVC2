using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAlbumFotos.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [StringLength(52,ErrorMessage ="Use menos caracteres")]
        public string Destino { get; set; }

        public string FotoTopo {get;set;}

        [DataType(DataType.Date)]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:dd/MM/yyyy")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:dd/MM/yyyy")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataFim { get; set; }

        public ICollection<Imagem> Imagens { get; set; }
    }
}
