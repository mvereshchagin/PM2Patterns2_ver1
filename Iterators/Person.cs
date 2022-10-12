using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators;

internal class Person
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime DateOfBirth { get; set; }

    public override string ToString()
    {
        return $"{Name} {Surname}, Email: {Email}, Date of birth: {DateOfBirth:yyyy.MM.dd}";
    }
}
