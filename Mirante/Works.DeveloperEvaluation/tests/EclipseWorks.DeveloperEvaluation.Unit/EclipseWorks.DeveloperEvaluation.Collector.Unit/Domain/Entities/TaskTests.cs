//using EclipseWorks.DeveloperEvaluation.Domain.Entities;
//using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using EclipseWorks.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using Xunit;

namespace EclipseWorks.DeveloperEvaluation.Unit.Domain.Entities;

/// <summary>
/// Contains unit tests for the task entity class.
/// Tests cover status changes and validation scenarios.
/// </summary>
public class TaskTests
{
    ///// <summary>
    ///// Tests that when a suspended project is activated, their status changes to Active.
    ///// </summary>
    //[Fact(DisplayName = "Task status should change to Active when activated")]
    //public void Given_CancelledTask_When_Activated_Then_StatusShouldBeActive()
    //{
    //    // Arrange
    //    var task = TaskTestData.GenerateValidTask();
    //    task.Status = DeveloperEvaluation.Domain.Enums.TaskStatus.Completed;

    //    // Act
    //    //task.Status= ;

    //    // Assert
    //    Assert.Equal(DeveloperEvaluation.Domain.Enums.TaskStatus.Completed, task.Status);
    //}

    ///// <summary>
    ///// Tests that when an active project is cancelled, their status changes to Cancelled.
    ///// </summary>
    //[Fact(DisplayName = "Task status should change to Cancelled when cancelled")]
    //public void Given_ActiveTask_When_Cancelled_Then_StatusShouldBeCancelled()
    //{
    //    // Arrange
    //    var task = TaskTestData.GenerateValidTask();
    //    task.Status = DeveloperEvaluation.Domain.Enums.TaskStatus.Progress;

    //    // Act
    //    //project.Deactivate();

    //    // Assert
    //    Assert.Equal(DeveloperEvaluation.Domain.Enums.TaskStatus.Progress, task.Status);
    //}

    ///// <summary>
    ///// Tests that validation passes when all project properties are valid.
    ///// </summary>
    //[Fact(DisplayName = "Validation should pass for valid task data")]
    //public void Given_ValidTaskData_When_Validated_Then_ShouldReturnValid()
    //{
    //    // Arrange
    //    var task = TaskTestData.GenerateValidTask();

    //    // Act
    //    var result = task.ValidateAsync();

    //    // Assert
    //    Assert.True(result.IsCompleted);
    //    //Assert.Empty(result.er);
    //}

    ///// <summary>
    ///// Tests that validation fails when task properties are invalid.
    ///// </summary>
    //[Fact(DisplayName = "Validation should fail for invalid task data")]
    //public void Given_InvalidTasktData_When_Validated_Then_ShouldReturnInvalid()
    //{
    //    // Arrange
    //    var task = new DeveloperEvaluation.Domain.Entities.Task
    //    {
    //        ProjectId = Guid.Empty,
    //        Title = string.Empty, // Invalid: empty
    //        Description = string.Empty,
    //        Details = string.Empty,
    //        //DueDate = DateTime.Now,
    //        //CreatedAt = DateTime.Now,
    //        Status = DeveloperEvaluation.Domain.Enums.TaskStatus.Unknown, // Invalid: cannot be Unknown
    //        Priority = Priority.Low // Invalid: cannot be None
    //    };

    //    // Act
    //    var result = task.ValidateAsync();

    //    // Assert
    //    Assert.True(result.IsCompleted);
    //    //Assert.NotEmpty(result.Errors);
    //}
}
