using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props;

internal class SimpleConsole : IConsole
{
    public string? ReadLine(string msg, params object?[] args)
    {
        return Console.ReadLine();
    }

    public void Write(string msg, params object?[] args)
    {
        Console.Write(msg, args);
    }

    public void WriteLine(string msg, params object?[] args)
    {
        Console.WriteLine(msg, args);
    }
}
