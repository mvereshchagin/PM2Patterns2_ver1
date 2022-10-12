using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroFavbric;

public class Hero
{
    public Hero(Weapon weapon, Movement movement)
    {
        weapon = Weapon;
        movement = Movement;
    }

    public Weapon Weapon { get; init; } = null!;

    public Movement Movement { get; init; } = null!;

    public void Hit()
    {
        Weapon.Hit();
    }

    public void Run()
    {
        Movement.Move();
    }
}

public class Thor : Hero
{
    public Thor() : base(new Molner(), new JumpMovement())
    { }
}
