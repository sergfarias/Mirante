using Bogus;
//using EclipseWorks.DeveloperEvaluation.Domain.Enums;
//using EclipseWorks.DeveloperEvaluation.Application.Projects.CreateProject;
namespace EclipseWorks.DeveloperEvaluation.Unit.Domain;

public static class CreateProjectHandlerTestData
{
    /// <summary>
    /// Configures the Faker to generate valid Project entities.
    /// </summary>
    //private static readonly Faker<CreateProjectCommand> createProjectHandlerFaker = new Faker<CreateProjectCommand>()
    //    .RuleFor(p => p.ProjectNumber, f => $"Test@{f.Random.Number(5, 10)}")
    //    //.RuleFor(p => p.ProjectDate, f => TimeProvider.System.GetUtcNow().AddDays(-5))
    //    .RuleFor(p => p.UserId, f => new Guid())
    //    //.RuleFor(u => u.Email, f => f.Internet.Email())
    //    //.RuleFor(u => u.Phone, f => $"+55{f.Random.Number(11, 99)}{f.Random.Number(100000000, 999999999)}")
    //    .RuleFor(p => p.Status, f => f.PickRandom(ProjectStatus.Active, ProjectStatus.Cancelled));
    //    //.RuleFor(p => p.CreatedAt, f => TimeProvider.System.GetUtcNow().AddDays(+5));

    ///// <summary>
    ///// Generates a valid Project entity with randomized data.
    ///// </summary>
    //public static CreateProjectCommand GenerateValidCommand()
    //{
    //    return createProjectHandlerFaker.Generate();
    //}
}
