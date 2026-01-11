//using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using Bogus;
//using TaskStatus = EclipseWorks.DeveloperEvaluation.Domain.Enums.TaskStatus;
namespace EclipseWorks.DeveloperEvaluation.Unit.Domain.Entities.TestData;

public static class TaskTestData
{
    /// <summary>
    /// Configures the Faker to generate valid Task entities.
    /// </summary>
    //private static readonly Faker<DeveloperEvaluation.Domain.Entities.Task> TaskFaker = new Faker<DeveloperEvaluation.Domain.Entities.Task>()
    //     .RuleFor(t => t.ProjectId, f => new Guid())
    //     .RuleFor(t => t.Title, f => GenerateText(15))
    //     .RuleFor(t => t.Description, f => GenerateText(25))
    //     .RuleFor(t => t.Details, f => GenerateText(100))
    //     //.RuleFor(t => t.DueDate, f => TimeProvider.System.GetUtcNow().AddDays(+5))
    //     //.RuleFor(t => t.CreatedAt, f => TimeProvider.System.GetUtcNow().AddDays(+5))
    //     .RuleFor(t => t.Status, f => f.PickRandom(TaskStatus.Completed, TaskStatus.Progress,  TaskStatus.Pending))
    //     .RuleFor(t => t.Priority, f => f.PickRandom(Priority.Average, Priority.Low, Priority.High));

    ///// <summary>
    ///// Generates a valid Task entity with randomized data.
    ///// </summary>
    //public static DeveloperEvaluation.Domain.Entities.Task GenerateValidTask()
    //{
    //    return TaskFaker.Generate();
    //}

    ///// <summary>
    ///// Generates a text.
    ///// </summary>
    //public static string GenerateText(int caracter)
    //{
    //    return new Faker().Random.String2(caracter);
    //}

}
