using Works.DeveloperEvaluation.Common.Security;
using Works.DeveloperEvaluation.Common.Validation;
using Works.DeveloperEvaluation.Domain.Enums;
using Works.DeveloperEvaluation.Domain.Validation;
using System.ComponentModel.DataAnnotations;
namespace Works.DeveloperEvaluation.Domain.Entities;

public class Tarefa : ITarefa //BaseEntity,
{
    [Key]
    public int ID { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Status Status { get; set; }
    public DateTime DataVencimento { get; set; }
   

    int ITarefa.ID => ID; 
    string ITarefa.Titulo => Titulo;
    string ITarefa.Descricao => Descricao;
    int ITarefa.Status => (int)Status;
    DateTime ITarefa.DataVencimento => DataVencimento;


    public ValidationResultDetail Validate()
    {
        var validator = new TarefaValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

}