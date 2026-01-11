using Works.DeveloperEvaluation.Frontend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configurar HttpClient para consumir a API
//object value = builder.Services.AddHttpClient(client =>
//{
//    client.BaseAddress = new Uri("https://localhost:7001/"); // URL da API
//    client.DefaultRequestHeaders.Add("Accept", "application/json");
//});

// Registrar HttpClient e o Serviço de Tarefas
builder.Services.AddHttpClient<ITarefaServices, TarefaServices>((serviceProvider, client) =>
{
    client.BaseAddress = new Uri("https://localhost:7181/"); // URL da sua API
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

//builder.Services.AddHttpClient<IAutorServices, AutorServices>((serviceProvider, client) =>
//{
//    client.BaseAddress = new Uri("https://localhost:7181/"); // URL da sua API
//    client.DefaultRequestHeaders.Add("Accept", "application/json");
//});

//builder.Services.AddHttpClient<IAssuntoServices, AssuntoServices>((serviceProvider, client) =>
//{
//    client.BaseAddress = new Uri("https://localhost:7181/"); // URL da sua API
//    client.DefaultRequestHeaders.Add("Accept", "application/json");
//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
