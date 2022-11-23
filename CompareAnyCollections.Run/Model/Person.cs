namespace CompareAnyCollections.Run.Model;

public class Person : IEquatable<Person>
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public bool Equals(Person? other) =>
        other is not null &&
        Name == other.Name &&
        Age == other.Age;
}