// Crea un nuevo objeto WebApplicationBuilder que configura la aplicación.
// 'args' es un array de argumentos que puede pasar información desde la línea de comandos.
var builder = WebApplication.CreateBuilder(args);

// Agrega servicios al contenedor de dependencias.
// Aquí se registra el servicio de controladores con vistas (MVC), lo que permite manejar peticiones y renderizar vistas.
builder.Services.AddControllersWithViews();

// Construye la aplicación usando la configuración definida en 'builder'.
var app = builder.Build();

// Configura el pipeline de solicitudes HTTP.
// Si la aplicación no está en el entorno de desarrollo...
if (!app.Environment.IsDevelopment())
{
    // Configura un manejador de excepciones para redirigir a una vista de error.
    app.UseExceptionHandler("/Home/Error");

    // Activa HSTS (HTTP Strict Transport Security) para mejorar la seguridad.
    // HSTS por defecto es 30 días, pero se puede ajustar para escenarios de producción.
    app.UseHsts();
}

// Redirige automáticamente las solicitudes HTTP a HTTPS.
app.UseHttpsRedirection();

// Sirve archivos estáticos (como imágenes, CSS, JavaScript) desde las carpetas predeterminadas (wwwroot).
app.UseStaticFiles();

// Agrega middleware de enrutamiento para manejar las solicitudes basadas en rutas definidas.
app.UseRouting();

// Agrega middleware de autorización para controlar el acceso a las rutas basadas en políticas de seguridad.
app.UseAuthorization();

// Define una ruta predeterminada para el enrutamiento de controladores.
// El patrón de ruta establece que por defecto se utilizará el controlador "Home" y la acción "Index".
// 'id?' indica que el parámetro 'id' es opcional.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//pattern: "{controller=Home}/{action=Privacy}/{id?}");//Esto cambia la pagina de inico


// Inicia la aplicación y comienza a escuchar las solicitudes entrantes.
app.Run();
