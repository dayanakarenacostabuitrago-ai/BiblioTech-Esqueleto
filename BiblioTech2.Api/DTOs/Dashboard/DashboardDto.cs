namespace BiblioTech.Api.DTOs.Dashboard;

public class DashboardDto
{
    public int TotalLibros { get; set; }
    public int EjemplaresDisponibles { get; set; }
    public int PrestamosActivos { get; set; }
    public int PrestamosVencidos { get; set; }
    public int SociosActivos { get; set; }
}