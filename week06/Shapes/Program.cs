using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        // shapes
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3.5));
        shapes.Add(new Square("Yellow", 2));
                
        Console.WriteLine("--- Calculating area---");

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            
            Console.WriteLine($"Color: {shape.GetColor()}, Type: {shape.GetType().Name}, Area: {area:F2}");
        }
        
        Console.WriteLine("-----------------");

    }
}