using BiblioTech2.Api.DTOs.Autores;
using BiblioTech2.Api.Models;
using BiblioTech2.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using BiblioTech2.Api.Respuestas;
using Microsoft.CodeAnalysis.Operations;

namespace BiblioTech2.Api.Controllers;


[Route("api/[controller]")]
public class AutoresController(IAutorService servicio): ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<RespuestaApi<List<AutorDto>>>> Listar()
        => Responder(await servicio.ListarAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<RespuestaApi<Autor>>> obtener(int id)
                 => Responder(await servicio.ObtenerAsync(id));
    

    [HttpPost]
    public async Task<ActionResult<RespuestaApi<AutorDto>>> Crear(AutorGuardadoDto dto)
    {
        var resultado = await servicio.CrearAsync(dto);
        if (!resultado.Exito)
            return Responder(resultado);

        return CreatedAtAction(nameof(obtener), new { id = resultado.Datos!.Id },
            RespuestaApi<AutorDto>.Desde(resultado));
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<RespuestaApi<object>>> Actualizar(int id, AutorGuardadoDto dto)
      => Responder(await servicio.ActualizarAsync(id, dto));


    [HttpDelete("{id:int}")]
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<RespuestaApi<object>>> Eliminar(int id)
     => Responder(await servicio.EliminarAsync(id));
}
