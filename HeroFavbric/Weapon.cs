using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroFavbric;

public abstract class Weapon
{
    public abstract void Hit();
}

public class HolyGrenade : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Pray! We have dropped holy grenade on you");
    }
}

public class Molner : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("We have used a molner");
    }
}
