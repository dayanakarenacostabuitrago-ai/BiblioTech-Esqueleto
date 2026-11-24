using BiblioTech.Api.DTOs.Auth;
using BiblioTech.Api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BiblioTech.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[AllowAnonymous]
public class AuthController(IAuthService servicio) : ControllerBase
{
    [HttpPost("login")]
    public async Task<ActionResult<LoginRespuestaDto>> Login(LoginDto dto)
    {
        var respuesta = await servicio.LoginAsync(dto);

        return respuesta is null
            ? Problem(statusCode: StatusCodes.Status401Unauthorized,
                      title: "No autorizado",
                      detail: "Correo o contraseña incorrectos.")
            : Ok(respuesta);
    }


    [HttpPost("registrar-inicial")]
    public async Task<IActionResult> RegistrarInicial(RegistrarUsuarioDto dto)
    {
        await servicio.RegistrarInicialAsync(dto);
        return StatusCode(StatusCodes.Status201Created);
    }
}