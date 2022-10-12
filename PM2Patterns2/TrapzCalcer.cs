using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM2Patterns2;

public class TrapzCalcer : Calcer
{
    public override double Calc(Func<double, double> f, double start, double end, int amountOfPoints)
    {
        var x = CreateLinspace(start, end, amountOfPoints);
        double res = 0;

        var dx = (x[^1] - x[0]) / (x.Length - 1);

        for(int i = 0; i < amountOfPoints; i++)
            res += f(x[i]) * dx;

        res += -f(x[^1]) * dx / 2 - f(x[0]) * dx / 2;

        return res;
    }
}
