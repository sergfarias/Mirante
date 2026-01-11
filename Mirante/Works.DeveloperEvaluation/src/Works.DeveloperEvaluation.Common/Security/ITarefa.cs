namespace Works.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de uma Tarefa no sistema.
    /// </summary>
    public interface ITarefa
    {
        public int ID { get;  }
        public string Titulo { get;  } 
        public string Descricao { get;  } 
        public int Status { get;  }
        public DateTime DataVencimento { get; }
    }
}


