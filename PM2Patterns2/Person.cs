using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM2Patterns2;
public class Person
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public Gender Gender { get; set; }

    public void Deconstruct(out string firstName, out string lastName)
    {
        firstName = this.FirstName;
        lastName = this.LastName;
    }

    public void Deconstruct(out string firstName, out string lastName, 
        out DateTime dateOfBirth, out Gender gender)
    {
        firstName = this.FirstName;
        lastName = this.LastName;
        dateOfBirth = this.DateOfBirth;
        gender = this.Gender;
    }
}

public enum Gender
{
    Male,
    Female
}
