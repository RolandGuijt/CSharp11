
var person = new Person { Name = "Roland" };

var personProcessor = new PersonProcessor();
var name = personProcessor.GetPersonName();

class Person
{
    public required string Name { get; init; } = string.Empty;
}

struct Coordinate
{
    public Coordinate()
    {
        X = 0;

    }
    public int X { get; set; }
    public int Y { get; set; }
}

