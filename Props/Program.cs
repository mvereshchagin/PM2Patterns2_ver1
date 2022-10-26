using Props;

Girl2 girl2 = new Girl2(name: "Евгения", surName: "Смольникова");
girl2.FavoriteFlower = "White Rose";
girl2.FavoriteJewerly = "bracelet";

Girl evgeniya = new Girl(Name: "Евгения", SurName: "Смольникова");
evgeniya.FavoriteFlower = "White Rose";
evgeniya.FavoriteJewerly = "bracelet";
evgeniya.Weight = 70;


var (name, surName) = evgeniya;

Console.WriteLine(evgeniya);
Console.WriteLine(girl2);

var elizaveta = new Girl(Name: "Елизавета", SurName: "Кесова");
elizaveta.FavoriteFlower = "Liliya";
elizaveta.FavoriteJewerly = "ring";
elizaveta.Weight = 60;
if (evgeniya == elizaveta)
{

}

var elizaveta2 = elizaveta with { FavoriteFlower = "Gladiolus", Weight = 120 };

var pointA = new Point3d() { X = 100, Y = 200, Z = 300 };
pointA.X = 150;

elizaveta.CompareTo(evgeniya);

var girls = new List<Girl>(new Girl[] { elizaveta, evgeniya, elizaveta2 });
girls.Sort();
Console.WriteLine("================== by Weight =====================");
foreach (var girl in girls)
    Console.WriteLine(girl);

girls.Sort(new GirlComparerByName());
Console.WriteLine("================== by Name ===================");
foreach (var girl in girls)
    Console.WriteLine(girl);

girls.Sort(new GirlComparerBySurName());
Console.WriteLine("================== by SurName ===================");
foreach (var girl in girls)
    Console.WriteLine(girl);

using var myConsole = new ColoredConsole() 
{ 
    ForegroundColor = ConsoleColor.Yellow, 
    BackgroundColor = ConsoleColor.Magenta
};
    // new SimpleConsole();

myConsole.WriteLine("ИВТ - лучшие!");
myConsole.WriteLine("Поступайте к нам!");
myConsole.WriteLine("Добро пожаловать!");





