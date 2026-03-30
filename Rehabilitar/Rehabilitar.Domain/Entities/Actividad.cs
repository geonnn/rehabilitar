using Rehabilitar.Domain.Enums;

namespace Rehabilitar.Domain.Entities;

public class Actividad
{
    public Guid Id { get; private set; }
    public DateTime Fecha { get; private set; }
    public FrecuenciaActividad Frecuencia { get; private set; }
    public User? Profesor { get; private set; }
    public int CupoMax { get; private set; }
    public string Descripcion { get; private set; } = string.Empty;
    public Sala Sala { get; private set; }
    public decimal Precio { get; private set; }

    #nullable disable
    private Actividad() { }
    #nullable enable

    public Actividad(DateTime fecha, FrecuenciaActividad frecuencia, int cupomax, string desc, Sala sala, decimal precio, User? profesor = null)
    {
        Id = Guid.NewGuid();
        Fecha = fecha;
        Frecuencia = frecuencia;
        Profesor = profesor;
        CupoMax = cupomax;
        Descripcion = desc;
        Sala = sala;
        Precio = precio;
    }
}
