using ConsoleApp;

//Project project = null;

//var thread = new Thread(() =>
//{
//    Thread.Sleep(1000);
//    project = Project.GetInstance("Name1");
//    project.Run();
//});
//thread.Start();

//Project project2 = null;

//new Thread(() =>
//{
//    project2 = Project.GetInstance("Name2");
//    project2.Run();
//}).Start();


//Console.WriteLine($"{project.Name} and {project2.Name}");
//Console.ReadLine();

Person[] persons =
{
    new() { Name = "Вася", Surname = "Пупкин", Email = "superpupkin@stud.kantiana.ru", Phone = "+77777777"},
    new() { Name = "Петя", Surname = "Запупыркин", Email = "pupyrkin@stud.kantiana.ru"},
    new() { Name = "Иван", Surname = "Нетудыхата", Phone = "+77777777"},
    new() { Name = "Николай", Surname = "Валуев", Patronymic = "Алибабаевич", Email = "alibaba@stud.kantiana.ru"},
    new() { Name = "Евгений", Surname = "Онегин", Patronymic="Абдуллаевич", Phone = "+77777777"},
    new() { Prefix = "Мистер", Name = "Макар", Surname = "Зеленый", Email = "zelenyi@stud.kantiana.ru", Phone = "+77777777"},
    new() { Prefix = "Мисс", Name = "Анна", Patronymic = "Иоанновна", Surname = "Романова", Email = "anyutka@russia.gov"},
};

foreach(var person in persons)
{
    Console.WriteLine("--------------------------------------");
    Console.WriteLine(person);
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("");
}

var connectionString = new ConnectionStringBuilder()
    .SetServer("localhost")
    .SetUser("misha")
    .SetPassword("123456")
    .SetDatabase("masterdb")
    .Build();

Console.WriteLine(connectionString);
