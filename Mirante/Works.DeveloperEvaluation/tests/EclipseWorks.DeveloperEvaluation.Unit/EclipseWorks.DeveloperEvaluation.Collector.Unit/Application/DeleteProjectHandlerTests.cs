using AutoMapper;
//using EclipseWorks.DeveloperEvaluation.Application.Projects.DeleteProject;
//using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
//using EclipseWorks.DeveloperEvaluation.ORM.Repositories;
using FluentAssertions;
using NSubstitute;

namespace EclipseWorks.DeveloperEvaluation.Unit.Application;

/// <summary>
/// Contains unit tests for the <see cref="DeleteProjectHandler"/> class.
/// </summary>
public class DeleteProjectHandlerTests
{
    //private readonly IProjectRepository _projectRepository;
    //private readonly ITaskRepository _taskRepository;
    //private readonly IMapper _mapper;
    //private readonly DeleteProjectHandler _handler;

    ///// <summary>
    ///// Initializes a new instance of the <see cref="DeleteProjectHandlerTests"/> class.
    ///// Sets up the test dependencies and creates fake data generators.
    ///// </summary>
    //public DeleteProjectHandlerTests()
    //{
    //    _projectRepository = Substitute.For<IProjectRepository>();
    //    _taskRepository = Substitute.For<ITaskRepository>();
    //    _handler = new DeleteProjectHandler(_projectRepository, _taskRepository);
    //}

    
    ///// <summary>
    ///// Tests that an invalid user deleting request throws a validation exception.
    ///// </summary>
    //[Fact(DisplayName = "Given invalid task data When deleting task Then throws validation exception")]
    //public async System.Threading.Tasks.Task Handle_InvalidRequest_ThrowsValidationException()
    //{
    //    // Given
    //    var command = new DeleteProjectCommand(new Guid()); // Empty command will fail validation

    //    // When
    //    var act = () => _handler.Handle(command, CancellationToken.None);

    //    // Then
    //    await act.Should().ThrowAsync<FluentValidation.ValidationException>();
    //}

}
