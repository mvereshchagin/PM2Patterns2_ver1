using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;

/// <summary>
/// Singleton project
/// </summary>
internal class Project
{
    private static Project _project = null!;
    private static int _counter;
    public string Name { get; init; }

    private Project(string name)
    {
        Name = name;
        _counter++;
    }

    public static Project GetInstance(string name)
    {
        if (_project is null)
            _project = new Project(name);

        return _project;
    }

    public void Run()
    {

    }
}
