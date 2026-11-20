using BiblioTech2.Api.DTOs.Autores;

namespace BiblioTech2.Api.Services.Interfaces
{
    public interface IAutorService
    {
        Task<List<AutorDto>> ListarAsync();
        Task<AutorDto?> ObtenerAsync(int id);
        Task<AutorDto> CrearAsync(AutorGuardadoDto dto);
        Task ActualizarAsync(int id, AutorGuardadoDto dto);
        Task EliminarAsync(int id);
    }
}