using Microsoft.AspNetCore.Builder;

namespace Works.DeveloperEvaluation.IoC;

public interface IModuleInitializer
{
    void Initialize(WebApplicationBuilder builder);
}
