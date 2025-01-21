// Crea un nuevo objeto WebApplicationBuilder que configura la aplicaci�n.
// 'args' es un array de argumentos que puede pasar informaci�n desde la l�nea de comandos.
var builder = WebApplication.CreateBuilder(args);

// Agrega servicios al contenedor de dependencias.
// Aqu� se registra el servicio de controladores con vistas (MVC), lo que permite manejar peticiones y renderizar vistas.
builder.Services.AddControllersWithViews();

// Construye la aplicaci�n usando la configuraci�n definida en 'builder'.
var app = builder.Build();

// Configura el pipeline de solicitudes HTTP.
// Si la aplicaci�n no est� en el entorno de desarrollo...
if (!app.Environment.IsDevelopment())
{
    // Configura un manejador de excepciones para redirigir a una vista de error.
    app.UseExceptionHandler("/Home/Error");

    // Activa HSTS (HTTP Strict Transport Security) para mejorar la seguridad.
    // HSTS por defecto es 30 d�as, pero se puede ajustar para escenarios de producci�n.
    app.UseHsts();
}

// Redirige autom�ticamente las solicitudes HTTP a HTTPS.
app.UseHttpsRedirection();

// Sirve archivos est�ticos (como im�genes, CSS, JavaScript) desde las carpetas predeterminadas (wwwroot).
app.UseStaticFiles();

// Agrega middleware de enrutamiento para manejar las solicitudes basadas en rutas definidas.
app.UseRouting();

// Agrega middleware de autorizaci�n para controlar el acceso a las rutas basadas en pol�ticas de seguridad.
app.UseAuthorization();

// Define una ruta predeterminada para el enrutamiento de controladores.
// El patr�n de ruta establece que por defecto se utilizar� el controlador "Home" y la acci�n "Index".
// 'id?' indica que el par�metro 'id' es opcional.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//pattern: "{controller=Home}/{action=Privacy}/{id?}");//Esto cambia la pagina de inico


// Inicia la aplicaci�n y comienza a escuchar las solicitudes entrantes.
app.Run();
