using System.ComponentModel; // Proporciona atributos que permiten cambiar nombres de propiedades para su presentación.
using System.ComponentModel.DataAnnotations; // Ofrece atributos de validación de datos y metadatos.

namespace Tutorial_ASP.NET.Models
{
    public class Category // Declara la clase `Category`, que representa un modelo de datos.
    {
        [Key] // Indica que esta propiedad es la clave primaria de la tabla.
        public int Id { get; set; }

        [Required] // Indica que el campo `Name` es obligatorio y no puede ser nulo o vacío.
        [DisplayName("Name")] // Cambia el nombre que se muestra para esta propiedad en formularios o vistas.
        [MaxLength(20)] // Especifica que la longitud máxima para `Name` es de 20 caracteres.
        public string Name { get; set; } // Propiedad `Name`, almacena el nombre de la categoría.

        [DisplayName("Display Order")] // Cambia el nombre que se muestra para esta propiedad en formularios o vistas.
        [Range(1, 100, ErrorMessage = "Se puede configurar el mensaje de error. numero invalido")]
        // Establece un rango válido entre 1 y 100 para el campo `DisplayOrder`.
        // Si el valor está fuera del rango, muestra un mensaje de error personalizado.
        public int DisplayOrder { get; set; } // Propiedad `DisplayOrder`, define el orden de la categoría.
    }
}
