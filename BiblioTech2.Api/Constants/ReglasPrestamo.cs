namespace BiblioTech.Api.Constants;

public static class ReglasPrestamo
{
    public const int MaximoPrestamosActivos = 3;

    public const int DiasPrestamo = 15;


    public const int DiasHabilesAviso = 7;
}


public static class EstadosPrestamo
{
    public const string Activo = "Activo";
    public const string Devuelto = "Devuelto";
    public const string Vencido = "Vencido";
}