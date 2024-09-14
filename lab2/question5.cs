using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class Shape1
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual void Describe()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    public class Circle : Shape1
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Describe()
        {
            Console.WriteLine($"This is a circle with radius {Radius}.");
        }
    }

    public class Rectangle1 : Shape1
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override void Describe()
        {
            Console.WriteLine($"This is a rectangle with width {Width} and height {Height}.");
        }
    }
    internal class question5
    {
       /* static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
            new Circle { Radius = 5 },
            new Rectangle { Width = 4, Height = 6 }
            };

            foreach (Shape shape in shapes)
            {
                shape.Describe();            
                Console.WriteLine($"Area: {shape.CalculateArea()}"); 
                Console.WriteLine();
                Console.ReadKey();
                Console.Read();
            }
        }*/
    }
}
