using Microsoft.AspNetCore.Identity;

namespace Rehabilitar.Domain.Entities;

public class Role : IdentityRole<Guid>
{
    private Role() { }

    public Role(string nombre) : base(nombre)
    {
        Id = Guid.NewGuid();
    }

}
