namespace BiblioTech.Api.DTOs.Libros;

public class LibroDto
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int? AnioPublicacion { get; set; }
    public int EjemplaresTotales { get; set; }
    public int EjemplaresDisponibles { get; set; }
    public List<AutorResumenDto> Autores { get; set; } = [];
}

public class AutorResumenDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
}