using AutoMapper;
//using EclipseWorks.DeveloperEvaluation.Application.Tasks.CreateTask;
//using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
using EclipseWorks.DeveloperEvaluation.Unit.Domain;
using FluentAssertions;
using NSubstitute;

namespace EclipseWorks.DeveloperEvaluation.Unit.Application;

/// <summary>
/// Contains unit tests for the <see cref="CreateTaskHandler"/> class.
/// </summary>
public class CreateTaskHandlerTests
{
    //private readonly ITaskRepository _taskRepository;
    //private readonly IMapper _mapper;
    //private readonly CreateTaskHandler _handler;

    ///// <summary>
    ///// Initializes a new instance of the <see cref="CreateTaskHandlerTests"/> class.
    ///// Sets up the test dependencies and creates fake data generators.
    ///// </summary>
    //public CreateTaskHandlerTests()
    //{
    //    _taskRepository = Substitute.For<ITaskRepository>();
    //    _mapper = Substitute.For<IMapper>();
    //    //_passwordHasher = Substitute.For<IPasswordHasher>();
    //    _handler = new CreateTaskHandler(_taskRepository, _mapper);
    //}

    ///// <summary>
    ///// Tests that a valid user creation request is handled successfully.
    ///// </summary>
    //[Fact(DisplayName = "Given valid task data When creating task Then returns success response")]
    //public async System.Threading.Tasks.Task Handle_ValidRequest_ReturnsSuccessResponse()
    //{
    //    // Given
    //    var command = CreateTaskHandlerTestData.GenerateValidCommand();
    //    var task = new DeveloperEvaluation.Domain.Entities.Task
    //    {
    //        Id = Guid.NewGuid(),
    //        ProjectId = command.ProjectId,
    //        Title = command.Title,
    //        Description = command.Description,
    //        Details = command.Details,
    //        DueDate = command.DueDate,
    //        //CreatedAt = command.CreatedAt,
    //        //Status = command.Status,
    //        Priority = command.Priority
    //    };

    //    var result = new CreateTaskResult
    //    {
    //        Id = task.Id,
    //    };

    //    _mapper.Map<DeveloperEvaluation.Domain.Entities.Task>(command).Returns(task);
    //    _mapper.Map<CreateTaskResult>(task).Returns(result);

    //    _taskRepository.CreateAsync(Arg.Any<DeveloperEvaluation.Domain.Entities.Task>(), Arg.Any<CancellationToken>())
    //        .Returns(task);
        
    //    // When
    //    //var createTaskResult = await _handler.Handle(command, CancellationToken.None);

    //    // Then
    //    //createTaskResult.Should().NotBeNull();
    //    //createTaskResult.Id.Should().Be(task.Id);
    //    //await _taskRepository.Received(1).CreateAsync(Arg.Any<DeveloperEvaluation.Domain.Entities.Task>(), Arg.Any<CancellationToken>());
    //}

    ///// <summary>
    ///// Tests that an invalid user creation request throws a validation exception.
    ///// </summary>
    //[Fact(DisplayName = "Given invalid task data When creating user Then throws validation exception")]
    //public async System.Threading.Tasks.Task Handle_InvalidRequest_ThrowsValidationException()
    //{
    //    // Given
    //    var command = new CreateTaskCommand(); // Empty command will fail validation

    //    // When
    //    var act = () => _handler.Handle(command, CancellationToken.None);

    //    // Then
    //    await act.Should().ThrowAsync<NullReferenceException>(); //FluentValidation.ValidationException>();
    //}

   
    ///// <summary>
    ///// Tests that the mapper is called with the correct command.
    ///// </summary>
    //[Fact(DisplayName = "Given valid command When handling Then maps command to task entity")]
    //public async System.Threading.Tasks.Task Handle_ValidRequest_MapsCommandToUser()
    //{
    //    // Given
    //    var command = CreateTaskHandlerTestData.GenerateValidCommand();
    //    var task = new DeveloperEvaluation.Domain.Entities.Task
    //    {
    //        Id = Guid.NewGuid(),
    //        ProjectId = command.ProjectId,
    //        Title = command.Title,
    //        Description = command.Description,
    //        Details = command.Details,
    //        DueDate = command.DueDate,
    //        //CreatedAt = command.CreatedAt,
    //        //Status = command.Status,
    //        Priority = command.Priority
    //    };

    //    _mapper.Map<DeveloperEvaluation.Domain.Entities.Task>(command).Returns(task);
    //    _taskRepository.CreateAsync(Arg.Any<DeveloperEvaluation.Domain.Entities.Task>(), Arg.Any<CancellationToken>())
    //        .Returns(task);
        
    //    // When
    //    await _handler.Handle(command, CancellationToken.None);

    //    // Then
    //    _mapper.Received(1).Map<DeveloperEvaluation.Domain.Entities.Task>(Arg.Is<CreateTaskCommand>(c =>
    //        c.ProjectId == command.ProjectId &&
    //        c.Title == command.Title &&
    //        c.Description == command.Description &&
    //        c.Details == command.Details &&
    //        c.Priority == command.Priority));
    //}
}
