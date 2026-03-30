namespace Rehabilitar.Domain.Entities;

public class Reserva
{
    public Guid Id { get; private set; }
    public User User { get; private set; }
    public Actividad Actividad { get; private set;}

    #nullable disable
    private Reserva() { }
    #nullable enable

    public Reserva(User user, Actividad actividad)
    {
        Id = Guid.NewGuid();
        User = user;
        Actividad = actividad;
    }
}
