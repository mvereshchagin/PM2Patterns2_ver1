using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern;

internal class Keyboard
{
    private Dictionary<int, ICommand> _commands = new();
    private Stack<ICommand> _commandsStack = new Stack<ICommand>();
    private Stack<ICommand> _redoCommandsStack = new Stack<ICommand>();

    public void SetCommand(int number, ICommand command)
    {
        if (_commands.ContainsKey(number))
            _commands[number] = command;
        else
            _commands.Add(number, command);
    }

    public void ResetCommand(int number)
    {
        if (_commands.ContainsKey(number))
            _commands.Remove(number);
    }

    public void PressKey(int number)
    {
        if(_commands.ContainsKey(number))
        {
            var command = _commands[number];
            command.Execute();
            _commandsStack.Push(command);
            _redoCommandsStack.Clear();
        }
    }

    public void Undo()
    {
        var command = _commandsStack.Peek();
        if (command is null)
            return;

        command.Undo();
        if(_commandsStack.Count > 0)
            _commandsStack.Pop();
        _redoCommandsStack.Push(command);
    }

    public void Redo()
    {
        if (_redoCommandsStack.Count == 0)
            return;

        var command = _redoCommandsStack.Peek();

        command.Redo();
        _commandsStack.Push(command);
        _redoCommandsStack.Pop();
    }
}
