using System;

namespace API.Models;

public class Tarefa
{
    public string TarefaId { get; set; } = Guid.NewGuid().ToString();
    public String? Titulo { get; set; }
    public String? Descricao { get; set; }
    public String? CriadoEm { get; set; }
    public Categoria? Categoria { get; set; }
    public String? CategoriaId { get; set; }
    public String? Status { get; set; } = "Não iniciada";
}
