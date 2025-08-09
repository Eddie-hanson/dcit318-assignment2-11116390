using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

  
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(5);
            Console.WriteLine($"Area of circle with radius 5: {circle.GetArea():F2}");


            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Area of rectangle 4x6: {rectangle.GetArea()}");
            Console.ReadLine();
        }
    }
}
