using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern;

internal class Broadcaster2
{
    public event EventHandler<OnChangeEventArgs> OnChange = null!;

    public class OnChangeEventArgs : EventArgs
    {
        public int Count { get; init; }
    }

    public void Run()
    {
        int counter = 0;
        while (true)
        {
            Thread.Sleep(3000);
            OnChange?.Invoke(this, new OnChangeEventArgs() { Count = counter });
            counter++;
        }
    }
}
