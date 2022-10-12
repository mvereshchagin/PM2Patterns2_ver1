using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroFavbric;

public abstract class Movement
{
    public abstract void Move();
}

public class RunMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Move");
    }
}

public class JumpMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Jump");
    }
}
