using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace WebApiControlStock.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        public string Nombre { get; set; }
    }
}
