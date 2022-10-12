using PM2Patterns2;
using HouseFabric;

Console.WriteLine("Hello, PM2");

FabricTest();

void AbsInterfaces()
{
    Person person1 = new Person()
    {
        FirstName = "Никита",
        LastName = "Канунов",
        Gender = Gender.Male,
        DateOfBirth = new DateTime(day: 11, month: 5, year: 1999),
    };

    var (firstName, secondName) = person1;

    Console.WriteLine($"{firstName} {secondName} злостно и ценично опоздал на пару");

    var (fName, lName, dateOfBirth, gender) = person1;

    Console.WriteLine($"{fName} {lName} не справился с обязанностями старосты");

    var calcer = new TrapzCalcer();
    var res1 = calcer.Calc(x => x * x, 0, 1, 10);
    Console.WriteLine(res1);
}

void FabricTest()
{
    var woodDeveloper = new WoodDeveloper("Рога и Копыта");
    var panelDeveloper = new PanelDeveloper("Ашот и братва");

    var houses = new List<House>();
    houses.Add(woodDeveloper.BuildHouse());
    houses.Add(woodDeveloper.BuildHouse());
    houses.Add(woodDeveloper.BuildHouse());

    houses.Add(panelDeveloper.BuildHouse());
    houses.Add(panelDeveloper.BuildHouse());

    foreach (var house in houses)
        Console.WriteLine(house);
}
