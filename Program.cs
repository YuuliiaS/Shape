using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        public abstract class Shape
        {
            public abstract void draw();
            public string color;
            public abstract bool equals(Shape f);
        }
        internal class Circle : Shape
        {
            private int[] coord;
            public override bool equals(Shape f)
            {
                return (f.color == this.color);
                return (f.GetType() == typeof(Circle));
            }
            public Circle(string color, int[] coord)
            {
                this.coord = coord;
                this.color = color;
            }
            public override void draw()
            {
                Console.WriteLine("........");
                Console.WriteLine("........");
                Console.WriteLine("........");
                Console.WriteLine("........");
                Console.WriteLine("........");
                Console.WriteLine("");
            }
        }
        public class Rectangle : Shape
        {
            private int[] coord;
            public override bool equals(Shape f)
            {
                return (f.color == this.color);
                return (f.GetType() == typeof(Rectangle));
            }
            public Rectangle(string color, int[] coord)
            {
                this.coord = coord;
                this.color = color;
            }
            public override void draw()
            {
                Console.WriteLine("    #####");
                Console.WriteLine("  #########");
                Console.WriteLine(" ###########");
                Console.WriteLine(" ###########");
                Console.WriteLine("  #########");
                Console.WriteLine("    #####");
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle("Зелёный", new int[] { 7, 10, 9, 3 }), 
            new Rectangle("Белый", new int[] { 7, 10, 9, 3 }), 
            new Circle("Жёлтый", new int[] { 7, 10, 9, 3 }), 
            new Rectangle("Оранжевый", new int[] { 7, 10, 9, 3 }) };
            foreach (var item in shapes)
            {
                item.draw();
            }
            Console.WriteLine(new Circle("Зелёный", new int[] { 7, 10, 9, 3 }).equals(new Circle("Зелёный", new int[] { 7, 10, 9, 3 })));
        }
    }
}
