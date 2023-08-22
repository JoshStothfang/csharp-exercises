using GeometricShapes;
/*
var quad1 = new Quad()
{
    side1 = 3,
    side2 = 4,
    side3 = 5,
    side4 = 6
};

var perimeter = quad1.Perimeter();

Console.WriteLine($"quad1 perimeter is {perimeter}");


var rect1 = new Rect()
{
    side1 = 3,
    side2 = 5
};

Console.WriteLine($"Perimeter is {rect1.Perimeter()}, Area is {rect1.Area()}");

var sq1 = new Sq()
{
    side = 5
};

Console.WriteLine($"Perimeter is {sq1.Perimeter()}, Area is {sq1.Area()}");
*/

var shape1 = new OORect(3, 5); //using constructor

Console.WriteLine($"Perimeter is {shape1.Perimeter()}, Area is {shape1.Area()}");

var shape2 = new OOSq(5); //using constructor

Console.WriteLine($"Perimeter is {shape2.Perimeter()}, Area is {shape2.Area()}");

var shape3 = GeometricShapeFactory.CreateInstance(10);
