using BiblioTech2.Api.DTOs.Autores;
using BiblioTech2.Api.Respuestas;

namespace BiblioTech2.Api.Services.Interfaces
{
    public interface IAutorService
    {
        Task<Resultado<List<AutorDto>>> ListarAsync();
        Task<Resultado<AutorDto?>>ObtenerAsync(int id);
        Task<Resultado<AutorDto>> CrearAsync(AutorGuardadoDto dto);
        Task<Resultado> ActualizarAsync(int id, AutorGuardadoDto dto);
        Task<Resultado> EliminarAsync(int id);
    }
}