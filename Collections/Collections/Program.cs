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