using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiControlStock.Filters;

namespace WebApiControlStock.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        [RegularExpression(@"^^[A]{3}\d{3}$", ErrorMessage = "Solo se permiten números entre 1 y 100")]
        [Column(TypeName = "varchar(6)")]
        public string Codigo { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Required]
        [validarLineaProducto]
        [Column(TypeName ="varchar(1)")]

        public string LineaProducto { get; set; }

        [Required]
        [Precio]
        [Column(TypeName ="money")]
        public decimal PrecioDecimal { get; set; }


        #region propiedades de navegacion

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        #endregion
    }
}
