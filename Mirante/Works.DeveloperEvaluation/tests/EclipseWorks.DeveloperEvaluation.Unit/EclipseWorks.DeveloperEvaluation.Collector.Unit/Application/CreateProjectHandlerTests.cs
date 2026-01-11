//using EclipseWorks.DeveloperEvaluation.Application.Projects.CreateProject;
//using EclipseWorks.DeveloperEvaluation.Common.Security;
//using EclipseWorks.DeveloperEvaluation.Domain.Entities;
//using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
using EclipseWorks.DeveloperEvaluation.Unit.Domain;
using AutoMapper;
using FluentAssertions;
using NSubstitute;

namespace EclipseWorks.DeveloperEvaluation.Unit.Application;

/// <summary>
/// Contains unit tests for the <see cref="InserirLivroHandler"/> class.
/// </summary>
public class CreateProjectHandlerTests
{
    //private readonly IProjectRepository _projectRepository;
    //private readonly IUserRepository _userRepository;
    //private readonly IMapper _mapper;
    //private readonly IPasswordHasher _passwordHasher;
    //private readonly InserirLivroHandler _handler;

    ///// <summary>
    ///// Initializes a new instance of the <see cref="CreateProjectHandlerTests"/> class.
    ///// Sets up the test dependencies and creates fake data generators.
    ///// </summary>
    //public CreateProjectHandlerTests()
    //{
    //    _projectRepository = Substitute.For<IProjectRepository>();
    //    _userRepository = Substitute.For<IUserRepository>();
    //    _mapper = Substitute.For<IMapper>();
    //    //_passwordHasher = Substitute.For<IPasswordHasher>();
    //    _handler = new CreateProjectHandler(_projectRepository, _userRepository, _mapper);
    //}

    ///// <summary>
    ///// Tests that a valid project creation request is handled successfully.
    ///// </summary>
    //[Fact(DisplayName = "Given valid project data When creating project Then returns success response")]
    //public async System.Threading.Tasks.Task Handle_ValidRequest_ReturnsSuccessResponse()
    //{
    //    // Given
    //    var command = CreateProjectHandlerTestData.GenerateValidCommand();
    //    var project = new Project
    //    {
    //        Id = Guid.NewGuid(),
    //        ProjectNumber = command.ProjectNumber,
    //        ProjectDate = command.ProjectDate,
    //        UserId = command.UserId,
    //        Status = command.Status,
    //        Tasks = command.Tasks
    //    };

    //    var result = new InserirLivroResult
    //    {
    //        Id = project.Id,
    //    };

    //    _mapper.Map<Project>(command).Returns(project);
    //    _mapper.Map<InserirLivroResult>(project).Returns(result);

    //    _projectRepository.CreateAsync(Arg.Any<Project>(), Arg.Any<CancellationToken>())
    //        .Returns(project);

    //    // When
    //    //var createProjectResult = await _handler.Handle(command, CancellationToken.None);

    //    // Then
    //    //createProjectResult.Should().NotBeNull();
    //    //createProjectResult.Id.Should().Be(project.Id);
    //    //await _projectRepository.Received(1).CreateAsync(Arg.Any<Project>(), Arg.Any<CancellationToken>());
    //}

    ///// <summary>
    ///// Tests that an invalid project creation request throws a validation exception.
    ///// </summary>
    //[Fact(DisplayName = "Given invalid project data When creating task Then throws validation exception")]
    //public async System.Threading.Tasks.Task Handle_InvalidRequest_ThrowsValidationException()
    //{
    //    // Given
    //    var command = new CreateProjectCommand(); // Empty command will fail validation

    //    // When
    //    var act = () => _handler.Handle(command, CancellationToken.None);

    //    // Then
    //    await act.Should().ThrowAsync<NullReferenceException>(); //FluentValidation.ValidationException>();
    //}

   
    ///// <summary>
    ///// Tests that the mapper is called with the correct command.
    ///// </summary>
    //[Fact(DisplayName = "Given valid command When handling Then maps command to project entity")]
    //public async System.Threading.Tasks.Task Handle_ValidRequest_MapsCommandToUser()
    //{
    //    // Given
    //    var command = CreateProjectHandlerTestData.GenerateValidCommand();
    //    var project = new Project
    //    {
    //        Id = Guid.NewGuid(),
    //        ProjectNumber = command.ProjectNumber,
    //        ProjectDate = command.ProjectDate,
    //        UserId = command.UserId,
    //        Status = command.Status,
    //        Tasks = command.Tasks
    //    };

    //    _mapper.Map<Project>(command).Returns(project);
    //    _projectRepository.CreateAsync(Arg.Any<Project>(), Arg.Any<CancellationToken>())
    //        .Returns(project);

    //    // When
    //    var act = async () => await _handler.Handle(command, CancellationToken.None);

    //    // Then
    //    //await act.Should().ThrowAsync<FluentValidation.ValidationException>();
    //    //_mapper.Received(1).Map<Project>(Arg.Is<CreateProjectCommand>(c =>
    //    //    c.ProjectNumber == command.ProjectNumber &&
    //    //    c.ProjectDate == command.ProjectDate &&
    //    //    c.UserId == command.UserId &&
    //    //    c.Status == command.Status &&
    //    //    c.Tasks == command.Tasks));

    //}
}
