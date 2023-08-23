using clib = ConsoleLibrary;

/*
var x = 12;
var y = 3;

Console.WriteLine($"{x} + {y} = {clib.Math.Add(x,y)}");
Console.WriteLine($"{x} - {y} = {clib.Math.Sub(x, y)}");
Console.WriteLine($"{x} * {y} = {clib.Math.Mult(x, y)}");
Console.WriteLine($"{x} / {y} = {clib.Math.Div(x, y)}");
*/

var x = 2;
var y = 3;

Console.WriteLine($"1 / {x} = {clib.Math.Inverse(x)}");
Console.WriteLine($"{x} % {y} = {clib.Math.Modulo(x, y)}");
Console.WriteLine($"{x} ^ 3 = {clib.Math.Cubed(x)}");

Console.WriteLine($"{x} ^ {y} = {clib.Math.Power(x, y)}");