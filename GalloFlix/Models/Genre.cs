using System.ComponentModel.DataAnnotations;

namespace GalloFlix.Models;

public class Genre
{
    [Key] // Notaçãozinha pra chave primária - entende-se que esse Id é chave primária (NOTAÇÃO VEM SEMPRE ANTES DA PROPRIEDADE)
    public byte Id { get; set; }

    [Required] // Requerido - Not Null no banco; torna o nome obrigatório
    [StringLength(30)] // Tamanho máximo da propriedade
    public string Name { get; set; } 
}
