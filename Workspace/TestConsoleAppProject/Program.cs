//var c = 17 % 2 == 0;
//Console.WriteLine(c);
/*
int[] ints = { 1, 2, 3, 4, 5 };
int sum = 0;

for(int idx = 0; idx < 5; idx++)
{
    sum += ints[idx];
}

Console.WriteLine(sum);

var stateCode = "OH";
var stateName = "";


if(stateCode == "OH")
{
    stateName = "Ohio";
} else if(stateCode == "KY")
{
    stateName = "Kentucky";
} else if (stateCode == "IN")
{
    stateName = "Indiana";
} else
{
    stateName = "I don't know";
}

//switch statement
switch(stateCode)
{
    case "OH":
        stateName = "Ohio";
        break;
    case "KY":
        stateName = "Kentucky";
        break;
    case "IN":
        stateName = "Indiana";
        break;
    default:
        stateName = "I don't know";
        break;
}

//switch expression
stateName = stateCode switch
{
    "OH" => "Ohio",
    "KY" => "Kentucky",
    "IN" => "Indiana",
    _ => "I don't know"
};

Console.WriteLine(stateName);
*/

using Workspace;

Student.Print("This is a static method display");

var megan = new Student("Megan");
//megan.Name = "Megan";
//megan.State = "OH";

var tony = new Student("Tony", "AZ");
//tony.Name = "Tony";
//tony.State = "AZ";

Console.WriteLine($"Students are {megan.Name} and {tony.Name}");

Console.WriteLine($"Cohort is {Student.CohortNumber}");

Student.CohortNumber = 40;

Console.WriteLine($"Cohort is {Student.CohortNumber}");

Console.WriteLine($"Megan ID is {megan.Id}");

Console.WriteLine($"Tony ID is {tony.Id}");