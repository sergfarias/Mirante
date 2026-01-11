using Works.DeveloperEvaluation.Domain.Repositories;
using Works.DeveloperEvaluation.ORM;
using Works.DeveloperEvaluation.ORM.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Works.DeveloperEvaluation.IoC.ModuleInitializers;

public class InfrastructureModuleInitializer : IModuleInitializer
{
    public void Initialize(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<DbContext>(provider => provider.GetRequiredService<Context>());
        builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();
        //builder.Services.AddScoped<IAssuntoRepository, AssuntoRepository>();
        //builder.Services.AddScoped<IAutorRepository, AutorRepository>();
        //builder.Services.AddScoped<ITarefaAssuntoRepository, TarefaAssuntoRepository>();
        //builder.Services.AddScoped<ITarefaAutorRepository, TarefaAutorRepository>();
        //builder.Services.AddScoped<IHistoryRepository, HistoryRepository>();
    }
}