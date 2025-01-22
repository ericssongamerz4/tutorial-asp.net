using Microsoft.AspNetCore.Mvc;
using Tutorial_ASP.NET.Data;
using Tutorial_ASP.NET.Models;

namespace Tutorial_ASP.NET.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AplicationDBContext _db; // Inyección de dependencia para acceder al contexto de base de datos

        // Constructor que inicializa el contexto de base de datos
        public CategoryController(AplicationDBContext db)
        {
            _db = db; // Asigna la instancia del contexto proporcionada por la inyección de dependencias
        }

        // Acción que muestra la lista de categorías
        public IActionResult Index()
        {
            // Obtiene todas las categorías de la base de datos y las convierte en una lista
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList); // Devuelve la vista con la lista de categorías como modelo
        }
        #region Create
        // Acción que muestra el formulario para crear una nueva categoría
        public IActionResult Create()
        {
            return View(); // Devuelve la vista vacía (el formulario de creación)
        }

        // Acción que procesa los datos enviados desde el formulario de creación
        [HttpPost] // Indica que esta acción responde a solicitudes HTTP POST
        public IActionResult Create(Category obj)
        {
            // Validación personalizada: verifica si el nombre es igual al orden de visualización
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                // Agrega un mensaje de error al modelo si la validación falla
                ModelState.AddModelError("Name", "The name and the display order are the same.");
            }
            // Verifica si el modelo es válido (incluye validaciones automáticas y personalizadas)
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj); // Agrega la nueva categoría al contexto de base de datos
                _db.SaveChanges(); // Guarda los cambios en la base de datos
                return RedirectToAction("Index", "Category"); // Redirige a la acción Index del controlador
            }
            return View(); // Si el modelo no es válido, vuelve a mostrar el formulario con errores
        }
        #endregion

        #region Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Las 3 hacen lo mismo
            Category? categoryFromDb = _db.Categories.Find(id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.Id == id);
            //Category? categoryFromDb2 = _db.Categories.Where(u => u.Id == id).FirstOrDefault();

            if (categoryFromDb == null) {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {

            return View();
        }
        #endregion
    }
}
