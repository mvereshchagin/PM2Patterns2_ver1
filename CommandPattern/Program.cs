using CommandPattern;

var keyboard = new Keyboard();
for(int i = 0; i < 10; i++)
{
    keyboard.SetCommand(i, new PrintKey(i.ToString()));
}

keyboard.PressKey(1);
keyboard.PressKey(2);
keyboard.PressKey(3);
keyboard.Undo();
keyboard.Undo();
keyboard.Redo();
keyboard.Redo();
keyboard.PressKey(6);
keyboard.Redo();
keyboard.PressKey(6);
keyboard.PressKey(7);
keyboard.Undo();


