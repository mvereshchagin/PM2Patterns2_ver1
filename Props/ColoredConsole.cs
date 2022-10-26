using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props;

internal class ColoredConsole : IConsole, IDisposable
{
    private readonly ConsoleColor _origBackgroundColor;
    private readonly ConsoleColor _origForegroundColor;
    private bool disposedValue;

    public ConsoleColor BackgroundColor 
    { 
        get => Console.BackgroundColor;
        set => Console.BackgroundColor = value;
    }

    public ConsoleColor ForegroundColor 
    {
        get => Console.ForegroundColor;
        set => Console.ForegroundColor = value;
    }


    public ColoredConsole()
    {
        _origBackgroundColor = Console.BackgroundColor;
        _origForegroundColor = Console.ForegroundColor;
    }

    public void Write(string msg, params object?[] args)
    {
        Console.Write(msg, args);
    }

    public void WriteLine(string msg, params object?[] args)
    {
        Console.WriteLine(msg, args);
    }

    public string? ReadLine(string msg, params object?[] args)
    {
        return Console.ReadLine();
    }

    public void Reset()
    {
        ForegroundColor = _origForegroundColor;
        BackgroundColor = _origBackgroundColor;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: освободить управляемое состояние (управляемые объекты)

                Reset();
            }

            // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
            // TODO: установить значение NULL для больших полей
            disposedValue = true;
        }
    }

    // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
    // ~ColoredConsole()
    // {
    //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
