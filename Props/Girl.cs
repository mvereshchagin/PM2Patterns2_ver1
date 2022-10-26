using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props;

internal record Girl(string Name, string SurName) : IEquatable<Girl>, IComparable<Girl>
{
    public Girl this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string FavoriteFlower { get; set; } = null!;

    public string FavoriteJewerly { get; set; } = null!;

    public int Weight { get; set; } = 100;

    public int CompareTo(Girl? other)
    {
        if (ReferenceEquals(this, other)) return 0;

        if (other is null)
            return 1;

        if (this.Weight == other.Weight) return 0;
        if (this.Weight > other.Weight) return 1;
        if (this.Weight < other.Weight) return -1;

        return 0;
    }
}

internal class GirlComparerByName : IComparer<Girl>
{
    public int Compare(Girl? x, Girl? y)
    {
        if (ReferenceEquals(x, y)) return 0;

        if (x is null && y is null) return 0;

        if (x is null) return -1;

        if (y is null) return 1;

        return (x.Name.CompareTo(y.Name));
    }
}

internal class GirlComparerBySurName : IComparer<Girl>
{
    public int Compare(Girl? x, Girl? y)
    {
        if (ReferenceEquals(x, y)) return 0;

        if (x is null && y is null) return 0;

        if (x is null) return -1;

        if (y is null) return 1;

        return (x.SurName.CompareTo(y.SurName));
    }
}

internal class GirlComparerByWeight : IComparer<Girl>
{
    public int Compare(Girl? x, Girl? y)
    {
        if (ReferenceEquals(x, y)) return 0;

        if (x is null && y is null) return 0;

        if (x is null) return -1;

        if (y is null) return 1;

        return x.Weight.CompareTo(y.Weight);
    }
}


internal class Girl2 : IEquatable<Girl2>, IComparable<Girl2>
{
    public Girl2(string name, string surName)
    {
        Name = name;
        SurName = surName;
    }

    public string Name { get; set; } = null!;

    public string SurName { get; set; } = null!;

    public string FavoriteFlower { get; set; } = null!;

    public string FavoriteJewerly { get; set; } = null!;

    public override string ToString()
    {
        return $"Girl {{ Name = {Name}, SurName = {SurName}," +
            $" FavoriteFlower = {FavoriteFlower}, FavoriteJewerly = {FavoriteJewerly }}}";
    }

    public void Deconstruct(out string name, out string surName)
    {
        name = Name;
        surName = SurName;
    }

    public Girl2 Copy()
    {
        var girl = new Girl2(name: Name, surName: SurName);
        girl.Name = Name;
        girl.SurName = SurName;
        girl.FavoriteFlower = FavoriteFlower;
        girl.FavoriteJewerly = FavoriteJewerly;
        return girl;
    }

    public bool Equals(Girl2? other)
    {
        throw new NotImplementedException();
    }

    public int CompareTo(Girl2? other)
    {
        throw new NotImplementedException();
    }

    public static bool operator ==(Girl2 girl1, Girl2 girl2)
    {
        if (girl1 is null && girl2 is null)
            return true;
        if (girl1 is null)
            return false;
        if (girl2 is null)
            return false;

        return (girl1.Name == girl2.Name &&
            girl1.SurName == girl2.SurName &&
            girl1.FavoriteFlower == girl2.FavoriteFlower &&
            girl1.FavoriteJewerly == girl2.FavoriteJewerly);

    }

    public static bool operator !=(Girl2 girl1, Girl2 girl2)
    {
        return !(girl1 == girl2);
    }
}
