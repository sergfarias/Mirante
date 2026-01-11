//using EclipseWorks.DeveloperEvaluation.Domain.Entities;
//using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using EclipseWorks.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using Xunit;

namespace EclipseWorks.DeveloperEvaluation.Unit.Domain.Entities;

/// <summary>
/// Contains unit tests for the Project entity class.
/// Tests cover status changes and validation scenarios.
/// </summary>
public class ProjectTests
{
    ///// <summary>
    ///// Tests that when a suspended project is activated, their status changes to Active.
    ///// </summary>
    //[Fact(DisplayName = "Project status should change to Active when activated")]
    //public void Given_CancelledProject_When_Activated_Then_StatusShouldBeActive()
    //{
    //    // Arrange
    //    var project = ProjectTestData.GenerateValidProject();
    //    project.Status = ProjectStatus.Cancelled;

    //    // Act
    //    project.Activate();

    //    // Assert
    //    Assert.Equal(ProjectStatus.Active, project.Status);
    //}

    ///// <summary>
    ///// Tests that when an active project is cancelled, their status changes to Cancelled.
    ///// </summary>
    //[Fact(DisplayName = "Project status should change to Cancelled when cancelled")]
    //public void Given_ActiveProject_When_Cancelled_Then_StatusShouldBeCancelled()
    //{
    //    // Arrange
    //    var project = ProjectTestData.GenerateValidProject();
    //    project.Status = ProjectStatus.Active;

    //    // Act
    //    project.Deactivate();

    //    // Assert
    //    Assert.Equal(ProjectStatus.Cancelled, project.Status);
    //}

    ///// <summary>
    ///// Tests that validation passes when all project properties are valid.
    ///// </summary>
    //[Fact(DisplayName = "Validation should pass for valid project data")]
    //public void Given_ValidProjectData_When_Validated_Then_ShouldReturnValid()
    //{
    //    // Arrange
    //    var project = ProjectTestData.GenerateValidProject();

    //    // Act
    //    var result = project.Validate();

    //    // Assert
    //    Assert.True(result.IsValid);
    //    Assert.Empty(result.Errors);
    //}

    ///// <summary>
    ///// Tests that validation fails when project properties are invalid.
    ///// </summary>
    //[Fact(DisplayName = "Validation should fail for invalid project data")]
    //public void Given_InvalidProjectData_When_Validated_Then_ShouldReturnInvalid()
    //{
    //    // Arrange
    //    var project = new Project
    //    {
    //        ProjectNumber = "", // Invalid: empty
    //        ProjectDate = DateTime.Now,
    //        UserId = Guid.Empty,
    //        //Password = UserTestData.GenerateInvalidPassword(), // Invalid: doesn't meet password requirements
    //        //Email = UserTestData.GenerateInvalidEmail(), // Invalid: not a valid email
    //        //Phone = UserTestData.GenerateInvalidPhone(), // Invalid: doesn't match pattern
    //        Status = ProjectStatus.Unknown // Invalid: cannot be Unknown
    //        //Role = UserRole.None // Invalid: cannot be None
    //    };

    //    // Act
    //    var result = project.Validate();

    //    // Assert
    //    Assert.False(result.IsValid);
    //    Assert.NotEmpty(result.Errors);
    //}
}
