using System.ComponentModel.DataAnnotations;

namespace BiblioTech.Api.DTOs.Prestamos;

public class PrestamoCrearDto
{
    [Range(1, int.MaxValue, ErrorMessage = "Selecciona un libro.")]
    public int LibroId { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Selecciona un socio.")]
    public int SocioId { get; set; }
}