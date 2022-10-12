using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators;

internal class PersonList : IEnumerable<Person>, INotifyCollectionChanged
{
    public List<Person> People { get; } = new();

    public event NotifyCollectionChangedEventHandler? CollectionChanged;

    public void Add(Person person)
    {
        People.Add(person);
        CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
    }

    public IEnumerator<Person> GetEnumerator()
    {
        return new PersonListEnumerator(People.ToArray());
    }

    public void Remove(Person person)
    {
        People.Remove(person);
        CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new PersonListEnumerator(People.ToArray());
    }
}

internal class PersonListEnumerator : IEnumerator<Person>
{
    private readonly Person[] _array;
    private int _position = -1;

    public PersonListEnumerator(Person[] array)
    {
        _array = array;
    }

    public Person Current => _array[_position];

    object IEnumerator.Current => _array[_position];

    public void Dispose()
    {

    }

    public bool MoveNext()
    {
        if(_position < _array.Length - 1)
        {
            _position++;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        _position = -1;
    }
}
