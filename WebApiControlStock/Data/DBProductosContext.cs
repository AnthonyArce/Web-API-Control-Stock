using Microsoft.EntityFrameworkCore;
using WebApiControlStock.Models;

namespace WebApiControlStock.Data
{
    public class DBProductosContext:DbContext
    {

        public DBProductosContext(DbContextOptions<DBProductosContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
