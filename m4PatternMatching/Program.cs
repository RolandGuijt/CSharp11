var ints = new int[] { 4, 6, 8, 9 };

if (ints is [ 4, 6, .. var rest ])
    Console.WriteLine("match");

var s = "Pluralsight";

if (s is ['P' or 'p', .. { Length: 9 }, 't'])
    Console.WriteLine("match");
