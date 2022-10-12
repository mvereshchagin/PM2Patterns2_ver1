using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFabric;

public class WoodDeveloper : Developer
{   
    public WoodDeveloper(string name) :  base(name)
    { }


    public override House BuildHouse()
    {
        return new WoodHouse();
    }
}
