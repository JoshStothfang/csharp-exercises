var numbers = "998729384798758143219885499245098734";

var numbersDictionary = new Dictionary<string, int>();

foreach (var ch in numbers.ToCharArray())
{
    if (!numbersDictionary.ContainsKey(ch.ToString()))
    {
        numbersDictionary[ch.ToString()] = 0;
    }

    numbersDictionary[ch.ToString()]++;
}

foreach (var key in numbersDictionary.Keys)
{
    Console.WriteLine($"The key {key} occurs {numbersDictionary[key]}");
}

/*
var numbersDictionary = new Dictionary<string, int>
{
    ["0"] = 0,
    ["1"] = 0,
    ["2"] = 0,
    ["3"] = 0,
    ["4"] = 0,
    ["5"] = 0,
    ["6"] = 0,
    ["7"] = 0,
    ["8"] = 0,
    ["9"] = 0
};

foreach (var ch in numbers.ToCharArray())
{
    numbersDictionary[ch.ToString()]++;
}

foreach (var key in numbersDictionary.Keys)
{
    Console.WriteLine($"The key {key} occurs {numbersDictionary[key]}");
}
*/


/*
var dictionary = new Dictionary<int, string>();

dictionary.Add(1, "Red");
dictionary.Add(2, "White");
dictionary.Add(3, "Blue");
dictionary.Add(4, "Orange");

Console.WriteLine($"The color for 4 is {dictionary[4]}");
*/



/*
var aList = new List<int>();
aList.AddRange(new int[] { 1, 2, 3, 4, 5 });
Console.WriteLine($"Default capacity is {aList.Capacity}");
//foreach (int i in aList) {} //or use .forEach method
*/


/*
List<string> names = new List<string>();
//or var names = new List<string>();

names.Add("Tony");
names.Add("Megan");
names.Add("Grant");
names.Add("Drew");
names.Add("David");
names.Add("Josh");

foreach(var name in names)
{
    Console.Write($"{name} ");
}

Console.WriteLine();
names.Remove("Josh");

foreach (var name in names)
{
    Console.Write($"{name} ");
}
*/