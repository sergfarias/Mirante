using AutoMapper;
//using EclipseWorks.DeveloperEvaluation.Application.Tasks.DeleteTask;
//using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
using FluentAssertions;
using NSubstitute;

namespace EclipseWorks.DeveloperEvaluation.Unit.Application;

/// <summary>
/// Contains unit tests for the <see cref="DeleteTaskHandler"/> class.
/// </summary>
public class DeleteTaskHandlerTests
{
    //private readonly ITaskRepository _taskRepository;
    //private readonly IMapper _mapper;
    //private readonly DeleteTaskHandler _handler;

    ///// <summary>
    ///// Initializes a new instance of the <see cref="DeleteTaskHandlerTests"/> class.
    ///// Sets up the test dependencies and creates fake data generators.
    ///// </summary>
    //public DeleteTaskHandlerTests()
    //{
    //    _taskRepository = Substitute.For<ITaskRepository>();
    //    _handler = new DeleteTaskHandler(_taskRepository);
    //}

    
    ///// <summary>
    ///// Tests that an invalid user deleting request throws a validation exception.
    ///// </summary>
    //[Fact(DisplayName = "Given invalid task data When deleting task Then throws validation exception")]
    //public async System.Threading.Tasks.Task Handle_InvalidRequest_ThrowsValidationException()
    //{
    //    // Given
    //    var command = new DeleteTaskCommand(new Guid()); // Empty command will fail validation

    //    // When
    //    var act = () => _handler.Handle(command, CancellationToken.None);

    //    // Then
    //    await act.Should().ThrowAsync<FluentValidation.ValidationException>();
    //}

}
