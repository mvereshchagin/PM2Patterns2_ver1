using ObserverPattern;

var broadcaster = new Broadcaster();
broadcaster.AddHandler((sender, count) =>
{
    Console.WriteLine($"handler1 handled message number {count}");
});

broadcaster.AddHandler((sender, count) =>
{
    Console.WriteLine($"handler2 handled message number {count}");
});

broadcaster.AddHandler(HandleFunc);

void HandleFunc(object sender, int count)
{
    Console.WriteLine($"HandleFunc handled message number {count}");
}

// broadcaster.Run();


var broadcaster2 = new Broadcaster2();
broadcaster2.OnChange += (sender, args) =>
{
    Console.WriteLine($"Handle by event with count = {args.Count}");
};
broadcaster2.OnChange += (sender, args) =>
{
    Console.WriteLine($"Handle 2 by event with count = {args.Count}");
};
broadcaster2.Run();
