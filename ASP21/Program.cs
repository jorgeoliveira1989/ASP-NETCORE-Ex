var builder = WebApplication.CreateBuilder(args);

// Configurar serviços
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar roteamento

//serve para enviar ficheiros e usar no programa
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();