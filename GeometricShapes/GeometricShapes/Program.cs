using GeometricShapes;

Console.WriteLine("Geometric Shapes!");

Quad q1 = new(3, 4, 5, 6);
Console.WriteLine($"Perimeter is { q1.Perimeter() }");

Rect r1 = new(3, 5);
Console.WriteLine($"Perimeter is {r1.Perimeter()} and Area is{r1.Area()}");

Sqr s1 = new(5);
Console.WriteLine($"Perimeter is {s1.Perimeter()} and Area is{s1.Area()}");