using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props;

internal interface IConsole
{
    public void Write(string msg, params object?[] args);

    public void WriteLine(string msg, params object?[] args);

    public string? ReadLine(string msg, params object?[] args);
}
