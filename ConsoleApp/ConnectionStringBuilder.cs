using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;

internal class ConnectionStringBuilder
{
    private string? _server;
    private string? _user;
    private string? _password;
    private string? _database;

    public ConnectionStringBuilder SetServer(string name)
    {
        _server = name;
        return this;
    }

    public ConnectionStringBuilder SetUser(string name)
    {
        _user = name;
        return this;
    }

    public ConnectionStringBuilder SetPassword(string password)
    {
        _password = password;
        return this;
    }

    public ConnectionStringBuilder SetDatabase(string database)
    {
        _database = database;
        return this;
    }

    public string Build()
    {
        StringBuilder sb = new StringBuilder();
        AppendItem(sb, "servername", _server);
        AppendItem(sb, "user", _user);
        AppendItem(sb, "password", _password);
        AppendItem(sb, "database", _database);
        return sb.ToString();
    }

    private void AppendItem(StringBuilder sb, string name, string? value)
    {
        if (!String.IsNullOrEmpty(value))
        {
            sb.Append($"{name}={value};");
        }
    }
}

