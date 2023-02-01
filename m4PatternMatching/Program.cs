var ints = new int[] { 4, 6, 8, 9 };

var filteredInts = ints.Where(GreaterThanFive);

var intsToo = new int[] { 6, 2, 1, 10 };
var filteredToo = ints.Where(GreaterThanFive);

static bool GreaterThanFive(int i)
{
    return i > 5;
}



if (ints is [ 4, 6, .. var rest ])
    Console.WriteLine("match");

ReadOnlySpan<char> s = "Pluralsight";

if (s is ['P' or 'p', .. { Length: 9 }, 't'])
    Console.WriteLine("match");
