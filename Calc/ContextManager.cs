﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc;

public class ContextManager
{
    public ICalcer GetCalcer()
    {
        return new Calcer1();
    }
}
