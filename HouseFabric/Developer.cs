using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFabric;

public abstract class Developer
{
    public Developer(string name)
    {
        Name = name;
    }

    public string Name { get; init; } = null!;

    public abstract House BuildHouse();
}
