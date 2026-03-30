namespace Rehabilitar.Domain.Entities;

public class Sala
{
    public Guid Id {get; private set;}
    public string Nombre {get; private set;} = string.Empty;

    private Sala() { }

    public Sala(string nombre)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
    }
}
