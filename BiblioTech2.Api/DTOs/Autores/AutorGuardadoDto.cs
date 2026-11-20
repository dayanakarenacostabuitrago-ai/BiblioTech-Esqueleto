using System.ComponentModel.DataAnnotations;

namespace BiblioTech2.Api.DTOs.Autores;

public class AutorGuardadoDto
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100, ErrorMessage="El nombre admite maximo 100 caracteres.")]

    public string Nombre { get; set; } = string.Empty;

    [StringLength(60,ErrorMessage ="La nacionalidad admite maximo 60 caracteres.")]
    public string? Nacionalidad { get; set; }
    
}
