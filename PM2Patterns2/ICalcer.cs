using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM2Patterns2;

internal interface ICalcer
{
    public double Calc(Func<double, double> f, double start, double end, int amountOfPoints);
}
