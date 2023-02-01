file class Person
{
    public string Name { get; set; } = string.Empty;
}

file interface IPersonProcessor
{
    string GetPersonName();
}

public class PersonProcessor : IPersonProcessor
{
    public string GetPersonName()
    {
        return new Person().Name;
    }
}