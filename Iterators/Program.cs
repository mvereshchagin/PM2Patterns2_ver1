using Iterators;

var personList = new PersonList();
personList.Add(
    new Person() 
    { 
        Name = "Василий", 
        Surname = "Пупкин", 
        DateOfBirth = new DateTime(year: 1970, month: 12, day: 31)
    });
personList.Add(
    new Person()
    {
        Name = "Иван",
        Surname = "Запупркин",
        DateOfBirth = new DateTime(year: 1960, month: 11, day: 21)
    });
personList.Add(
    new Person()
    {
        Name = "Александр",
        Surname = "Медведев",
        DateOfBirth = new DateTime(year: 1943, month: 12, day: 31)
    });

foreach(var person in personList)
{
    Console.WriteLine(person);
}
