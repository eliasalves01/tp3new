using InfnetWebApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configura o DbContext com a string de conexão do appsettings.json
builder.Services.AddDbContext<InfnetDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("InfnetDbContext")));

// Adiciona o Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Configurar o pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Redireciona a rota "/" para "/Alunos"
app.MapGet("/", () => Results.Redirect("/Alunos"));

app.MapRazorPages();
app.Run();
