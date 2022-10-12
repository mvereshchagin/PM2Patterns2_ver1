using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM2Patterns2;

public abstract class Calcer : ICalcer
{
    public abstract double Calc(Func<double, double> f, double start, double end, int amountOfPoints);

    protected double[] CreateLinspace(double start, double end, int amountOfPoints)
    {
        var array = new double[amountOfPoints];
        double step = (end - start) / (amountOfPoints - 1);
        double value = start;
        for(int i = 0; i < amountOfPoints; i++)
        {
            array[i] = value;
            value += step;
        }

        return array;
    }
}
