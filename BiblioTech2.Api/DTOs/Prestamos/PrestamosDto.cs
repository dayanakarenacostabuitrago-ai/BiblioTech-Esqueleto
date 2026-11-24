namespace BiblioTech.Api.DTOs.Prestamos;

public class PrestamosDto
{
    public int Id { get; set; }
    public int LibroId { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public int SocioId { get; set; }
    public string Socio { get; set; } = string.Empty;
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDevolucionEsperada { get; set; }
    public DateTime? FechaDevolucionReal { get; set; }

    public string Estado { get; set; } = string.Empty;
}