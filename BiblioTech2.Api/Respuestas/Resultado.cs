using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BiblioTech2.Api.Respuestas
{
    public class Resultado
    {
        public bool Exito { get; }
        public String Mensaje { get; }
        public TipoResultado Tipo { get; }

        protected Resultado(bool exito, String mensaje, TipoResultado tipo) {

            Exito = exito;
            Mensaje = mensaje;
            Tipo = tipo;
        }

        public static Resultado ok(String mensaje) => new Resultado(true, mensaje, TipoResultado.Exito);
        public static Resultado NoEncontrado(String mensaje) => new Resultado(false, mensaje, TipoResultado.NoEncontrado);
        public static Resultado ReglaDeNegocio(String mensaje) => new Resultado(false, mensaje, TipoResultado.ReglaNegocio);


    }

    public class Resultado<T> : Resultado
    {
         public T? Datos { get; }

        private Resultado(bool exito , String mensaje, TipoResultado tipo , T? datos): base(exito,mensaje,tipo)
        {
            Datos = datos;
        }
        public static Resultado<T> ok(T datos, String mensaje) => new(true, mensaje, TipoResultado.Exito, datos);
        public static new Resultado<T> NoEncontrado(String mensaje) =>new (false, mensaje,TipoResultado.NoEncontrado, default);
        public static new Resultado<T> ReglaNegocio(String mensaje) => new(false, mensaje, TipoResultado.ReglaNegocio, default);

    }
}
