//using EclipseWorks.DeveloperEvaluation.Common.Security;
//using EclipseWorks.DeveloperEvaluation.Domain.Entities;
//using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using EclipseWorks.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using Xunit;

namespace EclipseWorks.DeveloperEvaluation.Unit.Domain.Entities;

/// <summary>
/// Contains unit tests for the task entity class.
/// Tests cover status changes and validation scenarios.
/// </summary>
public class HistoryTests
{
    ///// <summary>
    ///// Tests that when a suspended project is activated, their status changes to Active.
    ///// </summary>
    //[Fact(DisplayName = "History status should change to History")]
    //public void Given_CancelledHistory_When_Activated_Then_StatusShouldBeActive()
    //{
    //    // Arrange
    //    var history = HistoryTestData.GenerateValidHistory();
    //    history.Status = HistoryStatus.Comment;

    //    // Act
    //    //task.Status= ;

    //    // Assert
    //    Assert.Equal(HistoryStatus.Comment, history.Status);
    //}

    ///// <summary>
    ///// Tests that when an active project is cancelled, their status changes to Cancelled.
    ///// </summary>
    //[Fact(DisplayName = "Task status should change to Cancelled when cancelled")]
    //public void Given_ActiveHistory_When_Cancelled_Then_StatusShouldBeCancelled()
    //{
    //    // Arrange
    //    var history = HistoryTestData.GenerateValidHistory();
    //    history.Status = HistoryStatus.History;

    //    // Act
    //    //project.Deactivate();

    //    // Assert
    //    Assert.Equal(HistoryStatus.History, history.Status);
    //}

    ///// <summary>
    ///// Tests that validation passes when all project properties are valid.
    ///// </summary>
    //[Fact(DisplayName = "Validation should pass for valid history data")]
    //public void Given_ValidHistoryData_When_Validated_Then_ShouldReturnValid()
    //{
    //    // Arrange
    //    var history = HistoryTestData.GenerateValidHistory();

    //    // Act
    //    var result = history.ValidateAsync();

    //    // Assert
    //    Assert.True(result.IsCompleted);
    //    //Assert.Empty(result.er);
    //}

    ///// <summary>
    ///// Tests that validation fails when history properties are invalid.
    ///// </summary>
    //[Fact(DisplayName = "Validation should fail for invalid history data")]
    //public void Given_InvalidHistoryData_When_Validated_Then_ShouldReturnInvalid()
    //{
    //    // Arrange
    //    var history = new History
    //    {
    //        TaskId = Guid.Empty,
    //        Details = string.Empty, // Invalid: empty
    //        //CreatedAt = DateTime.Now,
    //        CreatedUserId = Guid.Empty,
    //        Status = HistoryStatus.Unknown // Invalid: cannot be Unknown
    //    };

    //    // Act
    //    var result = history.ValidateAsync();

    //    // Assert
    //    Assert.True(result.IsCompleted);
    //    //Assert.NotEmpty(result.Errors);
    //}
}
