using Microsoft.EntityFrameworkCore; // Importa el paquete para trabajar con Entity Framework Core
using Tutorial_ASP.NET.Models; // Importa los modelos definidos en el proyecto

namespace Tutorial_ASP.NET.Data
{
    // Clase que representa el contexto de la base de datos
    public class AplicationDBContext : DbContext
    {
        // Constructor que permite inyectar opciones de configuración al contexto
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {
        }

        // Define una tabla en la base de datos para la entidad 'Category'
        public DbSet<Category> Categories { get; set; }

        // Método para configurar el modelo cuando se crea la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura datos iniciales (seeding) para la tabla 'Categories'
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ACCION", DisplayOrder = 1 }, // Primera categoría
                new Category { Id = 2, Name = "SCI-FI,", DisplayOrder = 2 }, // Segunda categoría
                new Category { Id = 3, Name = "TERROR", DisplayOrder = 3 }, // Tercera categoría
                new Category { Id = 4, Name = "DOCUMENTAL", DisplayOrder = 4 } // Cuarta categoría
            );
        }
    }
}
