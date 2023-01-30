using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiControlStock.Data;
using WebApiControlStock.Filters;
using WebApiControlStock.Models;


namespace WebApiControlStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        public readonly DBProductosContext context;

        public ProductoController(DBProductosContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [ServiceFilter(typeof(FiltroAccionPersonalizadaAttribute))]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            var autores = context.Productos.Include(x => x.Categoria).ToList();

            return autores;
        }

        [HttpPost]
        public ActionResult Post(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Productos.Add(producto);
            context.SaveChanges();

            return Ok();
        }
    }
}
