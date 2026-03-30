using Microsoft.AspNetCore.Identity;

namespace Rehabilitar.Domain.Entities;

public class User : IdentityUser<Guid>
{
    public string Nombre { get; private set; } = string.Empty;
    public string Apellido {get; private set;} = string.Empty;
    public int Dni { get; private set; }
    public DateOnly FechaNac { get; private set; }

    private User() { }

    public User(string nombre, string apellido, int dni, DateOnly fnac, string email, string telefono)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        Dni = dni;
        FechaNac = fnac;
        UserName = email;
        Email = email;
        PhoneNumber = telefono;
    }
}
