using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangular
{
    internal class Program
    {
      public abstract class Rectangle
        {
            public int width;
            public int hight;

            // Constructor without initial dimensions (defaults to 1)
            public Rectangle()
            {
                width = 1;
                hight = 1;
            }

            public Rectangle(int initialwidth, int initialhight)
            {
                this.width = initialwidth;
                this.hight = initialhight;
            }

            public double CalculateArea()
            {
                return width * hight;
            }

            public double  CalculatePerimeter()
            {
                return 2 * (width + hight);
            }

            public void display()
            {
                Console.WriteLine("Area: " +  CalculateArea());

                Console.WriteLine("perimeter: " + CalculatePerimeter());

            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
                r.display();

            Console.ReadLine();
        }
    }
}
