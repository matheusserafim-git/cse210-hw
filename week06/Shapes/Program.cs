using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Green", 3);
        shapes.Add(s1);
        
        Circle c1 = new Circle("Blue", 4);
        shapes.Add(c1);

        Rectangle r1 = new Rectangle("Yellow", 5, 3);
        shapes.Add(r1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.GetColor()}, Area: {shape.GetArea()}");  
        }
    }
}