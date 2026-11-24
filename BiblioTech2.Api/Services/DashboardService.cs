using BiblioTech.Api.DTOs.Dashboard;
using BiblioTech.Api.Services.Interfaces;
using BiblioTech2.Api.Data;

namespace BiblioTech.Api.Services;

public class DashboardService(BibliotecaContext db) : IDashboardService
{
    public Task<DashboardDto> ObtenerResumenAsync() => db.ObtenerResumenDashboardAsync();
}