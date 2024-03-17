using Task1.Model;
using Task1;

int[] position = { 4, 8 };
Shape shape = new Shape("Oblick", "Red", position);
Console.WriteLine($"Shape Name: {shape.Name}, Color: {shape.Color}, Position: ({shape.Position[0]}, {shape.Position[1]})");
Shape.Move(shape);
Console.WriteLine($"New Position after moving: ({shape.Position[0]}, {shape.Position[1]})");

// Test Rectangle class
Rectangle rectangle = new Rectangle("Pravoagolnik", "Yellow", position, 8, 15);
rectangle.getArea();
rectangle.getPerimeter();

// Test Circle class
Circle circle = new Circle("Krug", "Green", position, 9);
circle.getArea();
circle.getPerimeter();