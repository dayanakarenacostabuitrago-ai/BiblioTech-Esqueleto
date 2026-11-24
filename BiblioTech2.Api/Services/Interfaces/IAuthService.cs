using BiblioTech.Api.DTOs.Auth;

namespace BiblioTech.Api.Services.Interfaces;

public interface IAuthService
{
    Task<LoginRespuestaDto?> LoginAsync(LoginDto dto);

    Task RegistrarInicialAsync(RegistrarUsuarioDto dto);
}