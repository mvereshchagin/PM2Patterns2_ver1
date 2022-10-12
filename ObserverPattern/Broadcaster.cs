using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern;

internal class Broadcaster
{
    public delegate void BroadcastHandler(object sender, int count);

    private List<BroadcastHandler> _handlers = new();

    public void AddHandler(BroadcastHandler handler)
    {
        _handlers.Add(handler);
    }

    public void RemoveHandler(BroadcastHandler handler)
    {
        _handlers.Remove(handler);
    }

    public void Run()
    {
        int counter = 0;
        while (true)
        {
            Thread.Sleep(3000);
            foreach (var handler in _handlers)
                handler?.Invoke(this, counter);
            counter++;
        }
    }
}
