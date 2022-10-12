using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern;

internal class PrintHello : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Hello");
    }

    public void Redo()
    {
        throw new NotImplementedException();
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}

internal class PrintBye : ICommand
{
    public void Execute()
    {
        throw new NotImplementedException();
    }

    public void Redo()
    {
        throw new NotImplementedException();
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}

internal class PrintKey : ICommand
{
    private readonly string _key;
    public PrintKey(string key)
    {
        _key = key;
    }

    public void Execute()
    {
        Console.WriteLine($"Print {_key}");
    }

    public void Redo()
    {
        Console.WriteLine($"Redo {_key}");
    }

    public void Undo()
    {
        Console.WriteLine($"Undo print {_key}");
    }
}
