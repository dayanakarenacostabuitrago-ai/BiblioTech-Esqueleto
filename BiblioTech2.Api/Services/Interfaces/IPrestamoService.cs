using BiblioTech.Api.DTOs.Prestamos;

namespace BiblioTech.Api.Services.Interfaces;

public interface IPrestamoService
{
    Task<List<PrestamosDto>> ListarAsync(string? estado);
    Task<PrestamosDto> ObtenerAsync(int id);
    Task<PrestamosDto> CrearAsync(PrestamoCrearDto dto);
    Task DevolverAsync(int id);
    Task<List<PrestamoVencidoDto>> ListarVencidosAsync();
}