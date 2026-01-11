//using EclipseWorks.DeveloperEvaluation.Application.Tasks.CreateTask;
//using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using Bogus;

namespace EclipseWorks.DeveloperEvaluation.Unit.Domain;

public static class CreateTaskHandlerTestData
{
    /// <summary>
    /// Configures the Faker to generate valid Tasl entities.
    /// </summary>
    //private static readonly Faker<CreateTaskCommand> createTaskHandlerFaker = new Faker<CreateTaskCommand>()
    // .RuleFor(t => t.ProjectId, f => new Guid())
    //     .RuleFor(t => t.Title, f => GenerateText(15))
    //     .RuleFor(t => t.Description, f => GenerateText(25))
    //     .RuleFor(t => t.Details, f => GenerateText(100))
    //     //.RuleFor(t => t.DueDate, f => TimeProvider.System.GetUtcNow().AddDays(+5))
    //     //.RuleFor(t => t.CreatedAt, f => TimeProvider.System.GetUtcNow().AddDays(+5))
    //     //.RuleFor(t => t.Status, f => f.PickRandom(TaskStatus.Completed, TaskStatus.Progress, TaskStatus.Pending))
    //     .RuleFor(t => t.Priority, f => f.PickRandom(Priority.Average, Priority.Low, Priority.High));

    ///// <summary>
    ///// Generates a text.
    ///// </summary>
    //public static string GenerateText(int caracter)
    //{
    //    return new Faker().Random.String2(caracter);
    //}

    ///// <summary>
    ///// Generates a valid Task entity with randomized data.
    ///// </summary>
    //public static CreateTaskCommand GenerateValidCommand()
    //{
    //    return createTaskHandlerFaker.Generate();
    //}
}
