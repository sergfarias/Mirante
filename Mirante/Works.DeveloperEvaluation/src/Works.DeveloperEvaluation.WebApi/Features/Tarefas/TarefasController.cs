using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Works.DeveloperEvaluation.Application.Tarefas.AlterarTarefa;
using Works.DeveloperEvaluation.Application.Tarefas.BuscarTarefa;
using Works.DeveloperEvaluation.Application.Tarefas.DeletarTarefa;
using Works.DeveloperEvaluation.Application.Tarefas.InserirTarefa;
using Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;
using Works.DeveloperEvaluation.Application.Tarefas.RelatorioTarefa;
using Works.DeveloperEvaluation.WebApi.Common;
using Works.DeveloperEvaluation.WebApi.Features.Tarefas.AlterarTarefa;
using Works.DeveloperEvaluation.WebApi.Features.Tarefas.BuscarTarefa;
using Works.DeveloperEvaluation.WebApi.Features.Tarefas.DeletarTarefa;
using Works.DeveloperEvaluation.WebApi.Features.Tarefas.InserirTarefa;
using Works.DeveloperEvaluation.WebApi.Features.Tarefas.ListarTarefa;
using Works.DeveloperEvaluation.WebApi.Features.Tarefas.RelatorioTarefa;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas;

/// <summary>
/// Controller for managing task operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class TarefasController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of TarefasController
    /// </summary>
    /// <param name="mediator">The mediator instance</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public TarefasController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// Creates a new tarefa
    /// </summary>
    /// <param name="request">The tarefa creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created tarefa details</returns>
    [HttpPost("InserirTarefa")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetTarefaResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> InserirTarefa([FromBody] InserirTarefaRequest request, CancellationToken cancellationToken)
    {
        var validator = new InserirTarefaRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<InserirTarefaCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<GetTarefaResponse>
        {
            Success = true,
            Message = "Tarefa inserido com sucesso!",
            Data = _mapper.Map<GetTarefaResponse>(response)
        });
    }

    /// <summary>
    /// Modified a tarefa
    /// </summary>
    /// <param name="request">The tarefa Modified request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The Modified tarefa details</returns>
    [HttpPut("AlterarTarefa")]
    [ProducesResponseType(typeof(ApiResponseWithData<AlterarTarefaResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AlterarTarefa([FromBody] AlterarTarefaRequest request, CancellationToken cancellationToken)
    {
        var validator = new AlterarTarefaRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<AlterarTarefaCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<AlterarTarefaResponse>
        {
            Success = true,
            Message = "Tarefa alterado com sucesso!",
            Data = _mapper.Map<AlterarTarefaResponse>(response)
        });
    }

    /// <summary>
    /// Delete a tarefa
    /// </summary>
    /// <param name="request">The tarefa delete request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The delete tarefa details</returns>
    [HttpDelete("DeletarTarefa/{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<DeletarTarefaResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeletarTarefa([FromRoute] int Id, CancellationToken cancellationToken)
    {
        var command = new DeletarTarefaCommand(Id); 
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<DeletarTarefaResponse>
        {
            Success = true,
            Message = "Tarefa deletado com sucesso!",
            Data = _mapper.Map<DeletarTarefaResponse>(response)
        });
    }


    /// <summary>
    /// Retrieves a tarefa by their ID
    /// </summary>
    /// <param name="id">The unique identifier of the tarefa</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The tarefa details if found</returns>
    [HttpGet("TarefaById/{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<BuscarTarefaResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> TarefaById([FromRoute] int Id, CancellationToken cancellationToken)
    {
        var request = new BuscarTarefaRequest { ID = Id };

        var command = _mapper.Map<BuscarTarefaCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<BuscarTarefaResponse>
        {
            Success = true,
            Message = "Tarefa do código("+ Id + ") recuperado(s) com sucesso!",
            Data = _mapper.Map<BuscarTarefaResponse>(response)
        });
    }

    [HttpGet("TodosTarefas")]
    [ProducesResponseType(typeof(ApiResponseWithData<ListarTarefaResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListarTarefa([FromRoute] CancellationToken cancellationToken)
    {
        var request = new ListarTarefaRequest { };

        var command = _mapper.Map<ListarTarefaCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<List<ListarTarefaResponse>>
        {
            Success = true,
            Message = "Projeto(s) do usuário recuperado(s) com sucesso!",
            Data =_mapper.Map<List<ListarTarefaResponse>>(response)
        });
    }

    [HttpPost("RelatorioTarefas")]
    [ProducesResponseType(typeof(ApiResponseWithData<RelatorioTarefaResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RelatorioTarefa([FromBody] RelatorioTarefaRequest request, CancellationToken cancellationToken)
    {
        var command = _mapper.Map<RelatorioTarefaCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<List<RelatorioTarefaResponse>>
        {
            Success = true,
            Message = "Tarefa(s) recuperada(s) com sucesso!",
            Data = _mapper.Map<List<RelatorioTarefaResponse>>(response)
        });
    }

}
