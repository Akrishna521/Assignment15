using System;
namespace ShapeAreaLib
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Length * Width;
        }
    }

    public class Square : Rectangle
    {
        public override double Area()
        {
            return Length * Length;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}
public class RealAlgebra
{
    public double CalculateArea(string shape, double[] inputs)
    {
        ShapeAreaLib.Shape shapeInstance = null;
        switch (shape)
        {
            case "rectangle":
                shapeInstance = new ShapeAreaLib.Rectangle();
                break;
            case "square":
                shapeInstance = new ShapeAreaLib.Square();
                break;
            case "circle":
                shapeInstance = new ShapeAreaLib.Circle();
                break;
            case "triangle":
                shapeInstance = new ShapeAreaLib.Triangle();
                break;
        }

        for (int i = 0; i < inputs.Length; i++)
        {
            shapeInstance.GetType().GetProperty(shapeInstance.GetType().GetProperties()[i].Name).SetValue(shapeInstance, inputs[i]);
        }
        return shapeInstance.Area();
    }
}

